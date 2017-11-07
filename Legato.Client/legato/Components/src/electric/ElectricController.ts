import { ElectricGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import { IGuitarService } from "../../../Interfaces/interfaces";


export class ElectricController extends ControllerBase<ElectricGuitar> implements ng.IController {
    static $inject = ["$scope", "ElectricGuitarService"];

    constructor($scope: ng.IScope, service: IGuitarService<ElectricGuitar>) {
        super(service);

        $scope.$on("electric", (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sorting = params.sorting;
            this.paging.goToFirstPage();
            this.init();
        });
    }
}