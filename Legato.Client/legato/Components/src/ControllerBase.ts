import {
    Price,
    Guitar,
    Paging,
    Vendor,
    Sorting,
} from "../../Models/models";

import {
    IModalService,
    IGuitarService,
    IRoutingService,
    IContextMenuService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../Interfaces/interfaces";


export abstract class ControllerBase<TGuitar extends Guitar> {
    noResults: boolean;
    filter: {
        price: Price,
        vendors: Vendor[],
        sorting: Sorting,
        search: string
    } = {
        price: new Price(),
        vendors: [],
        sorting: new Sorting(),
        search: ""
    };
    globals: any;
    guitars: TGuitar[];
    error = false;
    paging: Paging = new Paging();

    constructor(protected $rootScope, protected service: IGuitarService<TGuitar>, protected routingService: IRoutingService,
                protected pendingTaskService: IPendingTaskService, protected filterUpdateService: IFilterUpdateService,
                protected modalService: IModalService, protected contextMenu: IContextMenuService) {
        this.setWatchers($rootScope);

        this.globals = this.$rootScope.globals;
        const stateName = this.routingService.urlSegments[1];
        const urlParamResolver = routingService.getParamResolver();
        
        this.filter.price = urlParamResolver.resolvePrice();
        this.filter.vendors = urlParamResolver.resolveVendors(null);
        this.filter.sorting = urlParamResolver.resolveSorting();

        this.getAmount().then(() => {
            const maxPage = Math.floor(this.paging.total / this.paging.itemsToShow);
            this.paging.currentPage = urlParamResolver.resolvePage(maxPage);
            this.paging.goToPage();
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
        return this.service.getAmount(this.filter.search, this.filter.price, this.filter.vendors).then(amount => {
            this.paging.total = amount;
        });
    }

    protected loadGuitarList() {
        this.guitars = [];
        this.error = false;

        if (this.filter.sorting && this.filter.sorting.required) {
            return this.service.getSortedGuitars(this.filter.search, this.filter.price, this.filter.vendors, this.paging, this.filter.sorting.name, this.filter.sorting.direction).then(guitars => {
                this.noResults = guitars.length === 0;
                this.guitars = guitars;
            }).catch(err => {
                this.error = true;
            });
        } else {
            return this.service.getGuitars(this.filter.search, this.filter.price, this.filter.vendors, this.paging).then(guitars => {
                this.noResults = guitars.length === 0;
                this.guitars = guitars;
            }).catch(err => {
                this.error = true;
            });
        }
    }

    protected onPageChanged(guitarName: string) {
        this.paging.goToPage();
        let params = this.routingService.queryParams;
        params.page = this.paging.currentPage;
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
                    this.goToFirstPage();
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
                    this.goToFirstPage();
                });
            }
            if (this.filterUpdateService.needUseVendorFilter(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.filterUpdateService.replaceVendorQueryParams(stateName);
                    this.filter.vendors = newValue.vendors;
                    this.goToFirstPage();
                });
            }
            if (this.filterUpdateService.needUseSorting(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.filterUpdateService.replaceSortingQueryParams(stateName);
                    this.filter.sorting = newValue.sorting;
                    this.goToFirstPage();
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

    private goToFirstPage() {
        this.paging.currentPage = 1;
        this.paging.goToPage();
        this.init();
    }
}