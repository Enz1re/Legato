import { WesternGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import { IGuitarService } from "../../../Interfaces/interfaces";


export class WesternController extends ControllerBase<WesternGuitar> implements ng.IController {
    static $inject = ["$scope", "WesternGuitarService"];

    constructor($scope: ng.IScope, service: IGuitarService<WesternGuitar>) {
        super(service);

        $scope.$on("western", (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sorting = params.sorting;
            this.paging.goToFirstPage();
            this.init();
        });
    }
}