import { WesternGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import { IGuitarService, IRoutingService } from "../../../Interfaces/interfaces";


export class WesternController extends ControllerBase<WesternGuitar> implements ng.IController {
    static $inject = ["$scope", "WesternGuitarService", "RoutingService"];

    constructor($scope: ng.IScope, service: IGuitarService<WesternGuitar>, routingService: IRoutingService) {
        super(service, routingService);
        
        $scope.$on("western", (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sorting = params.sorting;
            this.paging.goToPage();
            this.init();
        });
    }
}