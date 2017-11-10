import angular from "angular";
import uiRouter from "angular-ui-router";
import ngAnimate from "angular-animate";
import uiBootstrap from "angular-ui-bootstrap";

import services from "./Services/services-module";
import components from "./Components/components-module";
import filters from "./Filters/filters-module";

import Router from "./Routes/Router";

angular.module("legato", [uiRouter, ngAnimate, uiBootstrap, services, components, filters])
       .config(Router);

angular.element(document).ready(() => {
    angular.bootstrap(document.documentElement, ["legato"]);
});
