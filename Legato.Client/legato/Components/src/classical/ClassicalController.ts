import { ClassicalGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import { IGuitarService } from "../../../Interfaces/interfaces";


export class ClassicalController extends ControllerBase<ClassicalGuitar> implements ng.IController {
    static $inject = ["$scope", "ClassicalGuitarService"];

    constructor($scope: ng.IScope, service: IGuitarService<ClassicalGuitar>) {
        super(service);
        
        $scope.$on("classical", (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sorting = params.sorting;
            this.paging.goToFirstPage();
            this.init();
        });
    }
}