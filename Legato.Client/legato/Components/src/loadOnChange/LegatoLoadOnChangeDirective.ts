import angular from 'angular';

import {
    Price,
    Vendor,
    Sorting
} from "../../../Models/models";

import {
    IRoutingService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";

import { MainController } from "../../../Components/src/legato/MainController";


export class LegatoLoadOnChangeDirective implements ng.IDirective {
    restrict = "A";
    controller = "MainController";
    controllerAs = "mainCtrl";
    private inputTextFieldTypes = [
        "text", "password", "email", "number", "url", "search"
    ];
    private inputBoxTypes = [
        "checkbox", "radio"
    ];

    constructor(private onChangeService: IPendingTaskService, private routingService: IRoutingService, private filterUpdateService: IFilterUpdateService) {

    }

    link(scope: ng.IScope, element: JQLite, attrs: ng.IAttributes, mainCtrl: MainController) {
        scope.$watch(() => this.filterUpdateService.filter, (newValue, oldValue) => {
            const stateName = this.routingService.urlSegments()[1];
            this.onChangeService.cancelPendingTask();


            if (newValue.price.from !== oldValue.price.from || newValue.price.to !== oldValue.price.to) {
                this.onChangeService.setPendingTask(() => {
                    this.filterUpdateService.replacePriceQueryParams(stateName);
                });
            }
            else if (angular.toJson(newValue.vendors.filter(v => v.isSelected)) ===
                     angular.toJson(oldValue.vendors.filter(v => v.isSelected))) {
                this.onChangeService.setPendingTask(() => {
                    this.filterUpdateService.replaceVendorQueryParams(stateName);
                });
            }
            else if (newValue.sorting.required !== oldValue.sorting.required ||
                     newValue.sorting.name !== oldValue.sorting.name ||
                     newValue.sorting.direction !== oldValue.sorting.direction) {
                this.onChangeService.setPendingTask(() => {
                    this.filterUpdateService.replaceSortingQueryParams(stateName);
                })
            }
        }, true);
    }
    
    static create() {
        const directive: ng.IDirectiveFactory = (onChangeService: IPendingTaskService, routingService: IRoutingService, filterUpdateService: IFilterUpdateService) => {
            return new LegatoLoadOnChangeDirective(onChangeService, routingService, filterUpdateService);
        }
        directive.$inject = ["PendingTaskService", "RoutingService", "FilterUpdateService"];
        return directive;
    }
}