import { BassGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import { IGuitarService } from "../../../Interfaces/interfaces";


export class BassController extends ControllerBase<BassGuitar> implements ng.IController {
    static $inject = ["$scope", "BassGuitarService"];

    constructor($scope: ng.IScope, service: IGuitarService<BassGuitar>) {
        super(service);

        $scope.$on("bass", (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sorting = params.sorting;
            this.paging.goToFirstPage();
            this.init();
        });
    }
}