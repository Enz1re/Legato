import angular from "angular";

import * as controllers from "../Controllers/controllers-module";

export class Router {
    static $inject = ["$stateProvider", "$urlRouterProvider"];

    constructor($stateProvider: angular.ui.IStateProvider, $urlRouterProvider: angular.ui.IUrlRouterProvider) {
        $urlRouterProvider.otherwise("/");

        $stateProvider
            .state("/", {
                templateUrl: "../Templates/main.html",
                controller: controllers.MainController,
                controllerAs: "mainCtrl"
            })
            .state("/classical", {
                templateUrl: "../Templates/classical.html",
                controller: controllers.ClassicalController,
                controllerAs: "classicalCtrl"
            })
            .state("/western", {
                templateUrl: "../Templates/western.html",
                controller: controllers.WesternController,
                controllerAs: "westernCtrl"
            })
            .state("/electro", {
                templateUrl: "../Templates/electro.html",
                controller: controllers.ElectricController,
                controllerAs: "electroCtrl"
            })
            .state("/bass", {
                templateUrl: "../Templates/bass.html",
                controller: controllers.BassController,
                controllerAs: "bassCtrl"
            });
    }
}