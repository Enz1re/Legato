﻿import {
    Price,
    Guitar,
    Vendor,
    Sorting,
    GuitarFilter
} from "../../Models/models";

import {
    IUserService,
    IModalService,
    IGuitarService,
    IPagingService,
    IUpdateService,
    IRoutingService,
    IContextMenuService,
    IPendingTaskService,
} from "../../Interfaces/interfaces";


export abstract class ControllerBase<TGuitar extends Guitar> {
    noResults: boolean;
    filter: GuitarFilter = {
        price: new Price(),
        vendors: [],
        sorting: new Sorting(),
        search: ""
    };
    guitars: TGuitar[];
    error = false;

    constructor(protected $scope: ng.IScope, protected service: IGuitarService<TGuitar>, protected routingService: IRoutingService,
                protected pendingTaskService: IPendingTaskService, protected updateService: IUpdateService,
                protected modalService: IModalService, protected contextMenu: IContextMenuService, protected pagingService: IPagingService,
                protected userService: IUserService) {
        this.setWatchers();

        const stateName = this.routingService.urlSegments[1];
        const urlParamResolver = routingService.getParamResolver();
        
        this.filter.price = urlParamResolver.resolvePrice();
        this.filter.vendors = urlParamResolver.resolveVendors(null);
        this.filter.sorting = urlParamResolver.resolveSorting();

        this.getAmount().then(() => {
            const maxPage = this.pagingService.maxPage();
            this.pagingService.currentPage = urlParamResolver.resolvePage(maxPage);
            this.pagingService.goToSelectedPage();
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

    protected loadGuitarList(useCache = true) {
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
        this.pagingService.goToSelectedPage();
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

    private setWatchers() {
        this.$scope.$watch(() => this.updateService.filter, (newValue, oldValue) => {
            const stateName = this.routingService.urlSegments[1];
            this.pendingTaskService.cancelPendingTask();

            if (this.updateService.needSearch(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.updateService.replaceSearchQueryParams(stateName);
                    this.filter.search = newValue.search;
                    this.pagingService.goToFirstPage(() => this.init());
                });
            }
            if (this.updateService.needUsePriceFilter(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.updateService.replacePriceQueryParams(stateName);
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
            if (this.updateService.needUseVendorFilter(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.updateService.replaceVendorQueryParams(stateName);
                    this.filter.vendors = newValue.vendors;
                    this.pagingService.goToFirstPage(() => this.init());
                });
            }
            if (this.updateService.needUseSorting(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.updateService.replaceSortingQueryParams(stateName);
                    this.filter.sorting = newValue.sorting;
                    this.pagingService.goToFirstPage(() => this.init());
                });
            }
        }, true);
        this.$scope.$watch(() => this.updateService.updatePage, (newValue, oldValue) => {
            if (!newValue || !oldValue) {
                return;
            }

            this.service.clearCache();

            if (newValue.updateCurrentPage !== oldValue.updateCurrentPage) {
                this.init();
            }
            if (newValue.updateLastPage !== oldValue.updateLastPage) {
                this.pagingService.goToLastPage(() => { this.init(); });
            }
        }, true);
        this.$scope.$watch(() => this.userService.currentUser, (newVal, oldVal) => {
            if (newVal || oldVal) {
                if ((newVal && !oldVal) || (!newVal && oldVal) || (newVal.username !== oldVal.username)) {
                    this.userService.currentUser = newVal;
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