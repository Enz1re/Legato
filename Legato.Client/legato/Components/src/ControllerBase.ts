import angular from "angular";

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
    IPendingTaskService,
    IFilterUpdateService
} from "../../Interfaces/interfaces";


export abstract class ControllerBase<TGuitar extends Guitar> {
    noResults: boolean;
    guitars: TGuitar[];
    price: Price = new Price();
    vendors: Vendor[];
    sorting: Sorting = new Sorting();
    error = false;
    paging: Paging = new Paging();

    constructor(protected $scope: ng.IScope, protected service: IGuitarService<TGuitar>, protected routingService: IRoutingService,
                protected pendingTaskService: IPendingTaskService, protected filterUpdateService: IFilterUpdateService,
                protected modalService: IModalService) {
        this.setWatcher($scope);

        const urlParamResolver = routingService.getParamResolver();
        
        this.price = urlParamResolver.resolvePrice();
        this.vendors = urlParamResolver.resolveVendors(null);
        this.sorting = urlParamResolver.resolveSorting();
        this.getAmount().then(() => {
            const maxPage = Math.floor(this.paging.total / this.paging.itemsToShow);
            let urlPage = this.routingService.getParamResolver().resolvePage();

            if (urlPage > maxPage) {
                urlPage = maxPage;
                let params = this.routingService.queryParams;
                params.page = urlPage;
                this.routingService.replace(this.routingService.urlSegments[1], params);
            }

            this.paging.currentPage = urlPage;
            this.paging.goToPage();
        }).then(() => {
            this.loadGuitarList();
        }).catch(err => {
            this.error = true;
        })
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
        return this.service.getAmount(this.price, this.vendors).then(amount => {
            this.paging.total = amount;
        });
    }

    protected loadGuitarList() {
        this.guitars = [];
        this.error = false;

        if (this.sorting && this.sorting.required) {
            this.service.getSortedGuitars(this.price, this.vendors, this.paging, this.sorting.name, this.sorting.direction).then(guitars => {
                this.noResults = guitars.length === 0;
                this.guitars = guitars;
            }).catch(err => {
                this.error = true;
            });
        } else {
            this.service.getGuitars(this.price, this.vendors, this.paging).then(guitars => {
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

    protected onGuitarClick(guitar: Guitar) {
        this.modalService.open({
            guitar: () => guitar
        }).result.catch(() => { });
    }

    private setWatcher(scope: ng.IScope) {
        scope.$watch(() => this.filterUpdateService.filter, (newValue, oldValue) => {
            const stateName = this.routingService.urlSegments[1];
            this.pendingTaskService.cancelPendingTask();

            if (this.needUsePriceFilter(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.filterUpdateService.replacePriceQueryParams(stateName);
                    this.price = newValue.price;
                    this.init();
                });
            }
            if (this.needUseVendorFilter(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.filterUpdateService.replaceVendorQueryParams(stateName);
                    this.vendors = newValue.vendors;
                    this.init();
                });
            }
            if (this.needUseSorting(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.filterUpdateService.replaceSortingQueryParams(stateName);
                    this.sorting = newValue.sorting;
                    this.loadGuitarList();
                });
            }
        }, true);
    }

    private needUsePriceFilter(newValue, oldValue) {
        return newValue.price.from !== oldValue.price.from || newValue.price.to !== oldValue.price.to;
    }

    private needUseVendorFilter(newValue, oldValue) {
        return newValue.vendors.length > 0 && oldValue.vendors.length > 0 &&
            angular.toJson(newValue.vendors.filter(v => v.isSelected)) !== angular.toJson(oldValue.vendors.filter(v => v.isSelected))
    }

    private needUseSorting(newValue, oldValue) {
        return newValue.sorting.name !== oldValue.sorting.name ||
            newValue.sorting.direction !== oldValue.sorting.direction;
    }
}