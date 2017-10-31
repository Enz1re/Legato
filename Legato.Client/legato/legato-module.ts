import angular from "angular";
import uiRouter from "angular-ui-router";
import ngAnimate from "angular-animate";
import uiBootstrap from "angular-ui-bootstrap";

import services from "./Services/services-module";
import components from "./Components/components-module";
import filters from "./Filters/filters-module";

angular.module("legato", [uiRouter, ngAnimate, uiBootstrap, services, components, filters]);

angular.bootstrap(document.documentElement, ["legato"]);
