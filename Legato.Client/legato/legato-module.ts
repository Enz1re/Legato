import angular from "angular";
import uiRouter from "angular-ui-router";
import ngAnimate from "angular-animate";
import uiBootstrap from "angular-ui-bootstrap";
import ngCookies from "angular-cookies";

import services from "./Services/services-module";
import components from "./Components/components-module";
import filters from "./Filters/filters-module";

import Router from "./Routes/Router";

angular.module("legato", [ngCookies, uiRouter, ngAnimate, uiBootstrap, services, components, filters])
    .config(Router)
    .run(["$rootScope", "$state", "$cookies", "$http", ($rootScope, $state: ng.ui.IStateService, $cookies: ng.cookies.ICookiesService, $http: ng.IHttpService) => {
        $rootScope.globals = $cookies.getObject("globals") || {};
        if ($rootScope.globals.currentUser) {
            $http.defaults.headers.common["Authorization"] = `Bearer ${$rootScope.globals.currentUser.authData}`;
        }

        $rootScope.$on("$stateChangeStart", (event: ng.IAngularEvent, toState: ng.ui.IState, toParams, fromState: ng.ui.IState, fromParams) => {
            const isRestrictedPage = toState.name.toLowerCase() === "admin";
            const isLoggedIn = $rootScope.globals.currentUser;
            if (isRestrictedPage && !isLoggedIn) {
                $state.go("login");
            }
        });
    }]);

angular.element(document).ready(() => {
    angular.bootstrap(document.documentElement, ["legato"]);
});
