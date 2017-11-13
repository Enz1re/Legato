import { ElectricGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import { IGuitarService, IUrlParamResolverFactoryService } from "../../../Interfaces/interfaces";


export class ElectricController extends ControllerBase<ElectricGuitar> implements ng.IController {
    static $inject = ["$scope", "$state", "ClassicalGuitarService", "UrlParamResolverFactoryService"];

    constructor($scope: ng.IScope, $state: ng.ui.IStateService, service: IGuitarService<ElectricGuitar>, urlResolverFactory: IUrlParamResolverFactoryService) {
        super($state, service, urlResolverFactory);

        $scope.$on("electric", (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sorting = params.sorting;
            this.paging.goToPage();
            this.init();
        });
    }
}