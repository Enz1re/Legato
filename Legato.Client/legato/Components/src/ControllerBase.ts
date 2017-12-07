import {
    Price,
    Guitar,
    Vendor,
    Sorting,
    GuitarFilter
} from "../../Models/models";

import {
    IModalService,
    IGuitarService,
    IPagingService,
    IRoutingService,
    IContextMenuService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../Interfaces/interfaces";


export abstract class ControllerBase<TGuitar extends Guitar> {
    noResults: boolean;
    filter: GuitarFilter = {
        price: new Price(),
        vendors: [],
        sorting: new Sorting(),
        search: ""
    };
    globals: any;
    guitars: TGuitar[];
    error = false;

    constructor(protected $rootScope, protected service: IGuitarService<TGuitar>, protected routingService: IRoutingService,
                protected pendingTaskService: IPendingTaskService, protected filterUpdateService: IFilterUpdateService,
                protected modalService: IModalService, protected contextMenu: IContextMenuService, protected pagingService: IPagingService) {
        this.setWatchers($rootScope);

        this.globals = this.$rootScope.globals;
        const stateName = this.routingService.urlSegments[1];
        const urlParamResolver = routingService.getParamResolver();
        
        this.filter.price = urlParamResolver.resolvePrice();
        this.filter.vendors = urlParamResolver.resolveVendors(null);
        this.filter.sorting = urlParamResolver.resolveSorting();

        this.getAmount().then(() => {
            const maxPage = this.pagingService.maxPage();
            this.pagingService.currentPage = urlParamResolver.resolvePage(maxPage);
            this.pagingService.goToPage();
        }).then(() => {
            this.loadGuitarList().then(() => {
                const gIndex = urlParamResolver.resolveIndex(this.guitars.length - 1);
                if (!gIndex) {
                    return;
                }
                this.onGuitarClick(stateName, gIndex);
            });
        }).catch(err => {
            this.error = true;
        });
    }

    protected init() {
        this.error = false;
        this.getAmount().then(() => {
            this.loadGuitarList();
        }).catch(err => {
            this.error = true;
        });
    }

    protected getAmount() {
        return this.service.getAmount(this.filter).then(amount => {
            this.pagingService.total = amount;
        });
    }

    protected loadGuitarList() {
        this.guitars = [];
        this.error = false;

        if (this.filter.sorting && this.filter.sorting.required) {
            return this.service.getSortedGuitars(this.filter, this.pagingService.lowerBound, this.pagingService.upperBound).then(guitars => {
                this.noResults = guitars.length === 0;
                this.guitars = guitars;
            }).catch(err => {
                this.error = true;
            });
        } else {
            return this.service.getGuitars(this.filter, this.pagingService.lowerBound, this.pagingService.upperBound).then(guitars => {
                this.noResults = guitars.length === 0;
                this.guitars = guitars;
            }).catch(err => {
                this.error = true;
            });
        }
    }

    protected onPageChanged(guitarName: string) {
        this.pagingService.goToPage();
        let params = this.routingService.queryParams;
        params.page = this.pagingService.currentPage;
        this.routingService.replace(guitarName, params);
        this.loadGuitarList();
    }

    protected onGuitarClick(guitarName: string, index: number) {
        let params = this.routingService.queryParams;
        if (!params.g) {
            params.g = index;
            this.routingService.replace(guitarName, params);
        }

        this.modalService.openGuitarModal({
            gName: () => guitarName,
            guitars: () => this.guitars,
            currentIndex: () => index
        }).result.catch(() => {
            params.g = null;
            this.routingService.replace(guitarName, params);
        });
    }

    private setWatchers(scope) {
        scope.$watch(() => this.filterUpdateService.filter, (newValue, oldValue) => {
            const stateName = this.routingService.urlSegments[1];
            this.pendingTaskService.cancelPendingTask();

            if (this.filterUpdateService.needSearch(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.filterUpdateService.replaceSearchQueryParams(stateName);
                    this.filter.search = newValue.search;
                    this.pagingService.goToFirstPage(() => this.init());
                });
            }
            if (this.filterUpdateService.needUsePriceFilter(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.filterUpdateService.replacePriceQueryParams(stateName);
                    let from = newValue.price.from
                    let to = newValue.price.to;
                    if (from || to) {
                        if (!newValue.price.from)
                            from = 0
                        if (!newValue.price.to)
                            to = this.getMaxGuitarPrice();
                    }
                    this.filter.price = { from: from, to: to };
                    this.pagingService.goToFirstPage(() => this.init());
                });
            }
            if (this.filterUpdateService.needUseVendorFilter(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.filterUpdateService.replaceVendorQueryParams(stateName);
                    this.filter.vendors = newValue.vendors;
                    this.pagingService.goToFirstPage(() => this.init());
                });
            }
            if (this.filterUpdateService.needUseSorting(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.filterUpdateService.replaceSortingQueryParams(stateName);
                    this.filter.sorting = newValue.sorting;
                    this.pagingService.goToFirstPage(() => this.init());
                });
            }
        }, true);

        scope.$watch(() => scope.globals.currentUser, (newVal, oldVal) => {
            if (newVal || oldVal) {
                if ((newVal && !oldVal) || (!newVal && oldVal) || (newVal.username !== oldVal.username || newVal.authData !== oldVal.authData)) {
                    this.globals.currentUser = newVal;
                }
            }
        }, true);
    }

    private getMaxGuitarPrice() {
        let maxPrice = this.guitars[0].price;

        for (let g of this.guitars) {
            if (g.price > maxPrice) {
                maxPrice = g.price;
            }
        }

        return maxPrice;
    }
}