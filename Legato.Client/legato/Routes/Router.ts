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
                url: "/classical",
                templateUrl: "legato/Components/src/classical/classical.html",
                controller: ClassicalController,
                controllerAs: "classicalCtrl",
                params: UrlParams,
                //params: {
                //    from: null,
                //    to: null,
                //    vendors: null,
                //    name: null,
                //    direction: null
                //}
            })
            .state("western", {
                url: "/western",
                templateUrl: "legato/Components/src/western/western.html",
                controller: WesternController,
                controllerAs: "westernCtrl",
                params: {
                    from: null,
                    to: null,
                    vendors: null,
                    name: null,
                    direction: null
                }
            })
            .state("electric", {
                url: "/electric",
                templateUrl: "legato/Components/src/electric/electric.html",
                controller: ElectricController,
                controllerAs: "electricCtrl",
                params: {
                    from: null,
                    to: null,
                    vendors: null,
                    name: null,
                    direction: null
                }
            })
            .state("bass", {
                url: "/bass",
                templateUrl: "legato/Components/src/bass/bass.html",
                controller: BassController,
                controllerAs: "bassCtrl",
                params: {
                    from: null,
                    to: null,
                    vendors: null,
                    name: null,
                    direction: null
                }
            });

        $urlRouterProvider.otherwise("/classical?page=1");
    }
}