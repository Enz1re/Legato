import {
    ClassicalController,
    WesternController,
    ElectricController,
    BassController
} from "../Components/components-module";


export default class Router {
    static $inject = ["$stateProvider", "$urlRouterProvider"];

    constructor($stateProvider: ng.ui.IStateProvider, $urlRouterProvider: ng.ui.IUrlRouterProvider) {
        $stateProvider
            .state("classical", {
                url: "/classical",
                templateUrl: "legato/Components/src/classical/classical.html",
                controller: ClassicalController,
                controllerAs: "classicalCtrl"
            })
            .state("western", {
                url: "/western",
                templateUrl: "legato/Components/src/western/western.html",
                controller: WesternController,
                controllerAs: "westernCtrl"
            })
            .state("electric", {
                url: "/electric",
                templateUrl: "legato/Components/src/electric/electric.html",
                controller: ElectricController,
                controllerAs: "electricCtrl"
            })
            .state("bass", {
                url: "/bass",
                templateUrl: "legato/Components/src/bass/bass.html",
                controller: BassController,
                controllerAs: "bassCtrl"
            });

        $urlRouterProvider.otherwise("/classical");
    }
}