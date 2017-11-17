import {
    ClassicalController,
    WesternController,
    ElectricController,
    BassController
} from "../Components/components-module";

import { UrlParams } from "../Models/models";


export default class Router {
    static $inject = ["$stateProvider", "$urlRouterProvider"];

    constructor($stateProvider: ng.ui.IStateProvider, $urlRouterProvider: ng.ui.IUrlRouterProvider) {
        $stateProvider
            .state("classical", {
                url: "/classical?page&from&to&vendors&name&direction",
                template: "<classical price=\"mainCtrl.price\" vendors=\"mainCtrl.vendors\" sorting=\"mainCtrl.sorting\"></classical>",
                controller: ClassicalController,
                controllerAs: "classicalCtrl",
                reloadOnSearch: false
            })
            .state("western", {
                url: "/western?page&from&to&vendors&name&direction",
                template: "<western price=\"mainCtrl.price\" vendors=\"mainCtrl.vendors\" sorting=\"mainCtrl.sorting\"></western>",
                controller: WesternController,
                controllerAs: "westernCtrl",
                reloadOnSearch: false
            })
            .state("electric", {
                url: "/electric?page&from&to&vendors&name&direction",
                template: "<electric price=\"mainCtrl.price\" vendors=\"mainCtrl.vendors\" sorting=\"mainCtrl.sorting\"></electric>",
                controller: ElectricController,
                controllerAs: "electricCtrl",
                reloadOnSearch: false
            })
            .state("bass", {
                url: "/bass?page&from&to&vendors&name&direction",
                template: "<bass price=\"mainCtrl.price\" vendors=\"mainCtrl.vendors\" sorting=\"mainCtrl.sorting\"></bass>",
                controller: BassController,
                controllerAs: "bassCtrl",
                reloadOnSearch: false
            });

        $urlRouterProvider.otherwise("/classical?page=1");
    }
}