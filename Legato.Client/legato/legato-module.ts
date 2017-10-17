import angular from 'angular';
import uiRouter from 'angular-ui-router';
import ngAnimate from 'angular-animate';
import uiBootstrap from 'angular-ui-bootstrap';

import controllers from './Controllers/controllers-module';
import services from './Services/services-module';
import directives from './Directives/directives-module';
import filters from './Filters/filters-module';

import { Router } from './Routes/Router';

angular.module('legato', [uiRouter, ngAnimate, uiBootstrap, services, controllers, directives, filters])
    .config(Router);

angular.bootstrap(document.documentElement, ['legato']);