import { BassGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import { IGuitarService, IRoutingService } from "../../../Interfaces/interfaces";


export class BassController extends ControllerBase<BassGuitar> implements ng.IController {
    static $inject = ["$scope", "BassGuitarService", "RoutingService"];

    constructor($scope: ng.IScope, service: IGuitarService<BassGuitar>, routingService: IRoutingService) {
        super(service, routingService);
        
        $scope.$on("bass", (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sorting = params.sorting;
            this.paging.goToPage();
            this.init();
        });
    }
}