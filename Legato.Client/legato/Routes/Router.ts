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
                url: "/classical?page",
                templateUrl: "legato/Components/src/classical/classical.html",
                controller: ClassicalController,
                controllerAs: "classicalCtrl",
                params: UrlParams
            })
            .state("western", {
                url: "/western?page",
                templateUrl: "legato/Components/src/western/western.html",
                controller: WesternController,
                controllerAs: "westernCtrl",
                params: UrlParams
            })
            .state("electric", {
                url: "/electric?page",
                templateUrl: "legato/Components/src/electric/electric.html",
                controller: ElectricController,
                controllerAs: "electricCtrl",
                params: UrlParams
            })
            .state("bass", {
                url: "/bass?page",
                templateUrl: "legato/Components/src/bass/bass.html",
                controller: BassController,
                controllerAs: "bassCtrl",
                params: UrlParams
            });

        $urlRouterProvider.otherwise("/classical?page=1");
    }
}