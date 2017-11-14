import { ClassicalGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import { IGuitarService, IRoutingService } from "../../../Interfaces/interfaces";


export class ClassicalController extends ControllerBase<ClassicalGuitar> implements ng.IController {
    static $inject = ["$scope", "ClassicalGuitarService", "RoutingService"];

    constructor($scope: ng.IScope, service: IGuitarService<ClassicalGuitar>, routingService: IRoutingService) {
        super(service, routingService);
        
        $scope.$on("classical", (e, params) => {
            console.log(params);
            this.price = params.price;
            this.vendors = params.vendors;
            this.sorting = params.sorting;
            this.paging.goToPage();
            this.init();
        });
    }
}