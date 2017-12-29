import angular from "angular";
import uiRouter from "angular-ui-router";
import ngAnimate from "angular-animate";
import uiBootstrap from "angular-ui-bootstrap";
import ngCookies from "angular-cookies";
import ngFileUpload from "ng-file-upload";

import services from "./Services/services-module";
import components from "./Components/components-module";
import filters from "./Filters/filters-module";

import {
    IClaimService,
    IAuthenticationService
} from "./Interfaces/interfaces";

import Router from "./Routes/Router";

angular.module("legato", [ngCookies, uiRouter, ngAnimate, uiBootstrap, ngFileUpload, services, components, filters])
    .config(Router)
    .run(["$state", "$cookies", "$http", "AuthenticationService", "ClaimService", ($state: ng.ui.IStateService, $cookies: ng.cookies.ICookiesService,
                                                                                   $http: ng.IHttpService, authService: IAuthenticationService,
                                                                                   claimService: IClaimService) => {
        let globals = $cookies.getObject("globals") || {};

        if (globals.accessToken) {
            authService.getUser(globals.accessToken).then(() => {
                $http.defaults.headers.common["Authorization"] = `Bearer ${globals.accessToken}`;
            }).then(() => {
                claimService.getUserClaims();
            });
        }
    }]);

angular.element(document).ready(() => {
    angular.bootstrap(document.documentElement, ["legato"]);
});
