import { ElectricGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import { IGuitarService, IRoutingService } from "../../../Interfaces/interfaces";


export class ElectricController extends ControllerBase<ElectricGuitar> implements ng.IController {
    static $inject = ["$scope", "ElectricGuitarService", "RoutingService"];

    constructor($scope: ng.IScope, service: IGuitarService<ElectricGuitar>, routingService: IRoutingService) {
        super(service, routingService);
        
        $scope.$on("electric", (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sorting = params.sorting;
            this.paging.goToPage();
            this.init();
        });
    }
}