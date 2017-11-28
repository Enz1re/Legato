import {
    ClassicalController,
    WesternController,
    ElectricController,
    BassController,
    LoginController,
    MainController
} from "../Components/components-module";

import { UrlParams } from "../Models/models";


export default class Router {
    static $inject = ["$stateProvider", "$urlRouterProvider"];

    constructor($stateProvider: ng.ui.IStateProvider, $urlRouterProvider: ng.ui.IUrlRouterProvider) {
        $stateProvider
            .state("classical", {
                url: "/classical?page&from&to&vendors&name&direction&search&g",
                templateUrl: "legato/Components/src/classical/classical.html",
                controller: ClassicalController,
                controllerAs: "classicalCtrl",
                reloadOnSearch: false
            })
            .state("western", {
                url: "/western?page&from&to&vendors&name&direction&search&g",
                templateUrl: "legato/Components/src/western/western.html",
                controller: WesternController,
                controllerAs: "westernCtrl",
                reloadOnSearch: false
            })
            .state("electric", {
                url: "/electric?page&from&to&vendors&name&direction&search&g",
                templateUrl: "legato/Components/src/electric/electric.html",
                controller: ElectricController,
                controllerAs: "electricCtrl",
                reloadOnSearch: false
            })
            .state("bass", {
                url: "/bass?page&from&to&vendors&name&direction&search&g",
                templateUrl: "legato/Components/src/bass/bass.html",
                controller: BassController,
                controllerAs: "bassCtrl",
                reloadOnSearch: false
            })
            .state("login", {
                url: "/login?redirectUrl",
                templateUrl: "legato/Components/src/login/login.html",
                controller: LoginController,
                controllerAs: "loginCtrl",
                reloadOnSearch: false
            });

        $urlRouterProvider.otherwise("/classical?page=1");
    }
}