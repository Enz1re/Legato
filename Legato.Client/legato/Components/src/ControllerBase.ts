import angular from "angular";

import {
    Price,
    Guitar,
    Paging,
    Vendor,
    Sorting,
} from "../../Models/models";

import {
    IGuitarService,
    IRoutingService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../Interfaces/interfaces";


export abstract class ControllerBase<TGuitar extends Guitar> {
    noResults: boolean;
    guitars: TGuitar[];
    price: Price;
    vendors: Vendor[];
    sorting: Sorting = new Sorting();
    error = false;
    paging: Paging = new Paging();

    constructor(protected $scope: ng.IScope, protected service: IGuitarService<TGuitar>, protected routingService: IRoutingService,
                protected pendingTaskService: IPendingTaskService, protected filterUpdateService: IFilterUpdateService) {
        $scope.$watch(() => this.filterUpdateService.filter, (newValue, oldValue) => {
            const stateName = this.routingService.urlSegments[1];
            this.pendingTaskService.cancelPendingTask();

            if (this.needUsePriceFilter(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.filterUpdateService.replacePriceQueryParams(stateName);
                    this.price = newValue.price;
                    this.init();
                });
            }
            else if (this.needUseVendorFilter(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.filterUpdateService.replaceVendorQueryParams(stateName);
                    this.vendors = newValue.vendors;
                    this.init();
                });
            }
            else if (this.needUseSorting(newValue, oldValue)) {
                this.pendingTaskService.setPendingTask(() => {
                    this.filterUpdateService.replaceSortingQueryParams(stateName);
                    this.sorting = newValue.sorting;
                    this.init();
                });
            }
        }, true);

        this.paging.currentPage = routingService.getParamResolver().resolvePage();
        this.init();
    }
    
    protected onPageChanged(guitarName: string) {
        this.paging.goToPage();
        this.routingService.replace(guitarName, this.routingService.queryParams);
        this.loadGuitarList();
    }

    protected init() {
        this.error = false;
        this.service.getAmount(this.price, this.vendors).then(amount => {
            this.paging.total = amount;
        }).then(() => {
            this.loadGuitarList();
        }).catch(err => {
            this.error = true;
        });
    }

    protected loadGuitarList() {
        this.guitars = [];
        this.error = false;

        if (this.sorting.required) {
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

    private needUsePriceFilter(newValue, oldValue) {
        return newValue.price.from !== oldValue.price.from || newValue.price.to !== oldValue.price.to;
    }

    private needUseVendorFilter(newValue, oldValue) {
        return angular.toJson(newValue.vendors.filter(v => v.isSelected)) !== angular.toJson(oldValue.vendors.filter(v => v.isSelected))
    }

    private needUseSorting(newValue, oldValue) {
        return newValue.sorting.required !== oldValue.sorting.required ||
               newValue.sorting.name !== oldValue.sorting.name ||
               newValue.sorting.direction !== oldValue.sorting.direction;
    }
}