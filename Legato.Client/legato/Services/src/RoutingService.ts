import UrlParamResolver from "../src/UrlParamResolver";

import { UrlParams } from "../../Models/models";

import { IRoutingService, IUrlParamResolver } from "../../Interfaces/interfaces";


export default class RoutingService implements IRoutingService {
    static $inject = ["$state", "$stateParams", "$location"];

    constructor(private $state: ng.ui.IStateService, private $stateParams: ng.ui.IStateParamsService, private $location: ng.ILocationService) {

    }

    get url() {
        return this.$location.url();
    }

    get urlSegments() {
        return this.$location.path().split('/');
    }

    get queryParams() {
        return this.$stateParams;
    }

    getParamResolver(): IUrlParamResolver {
        return new UrlParamResolver(this.$stateParams, this);
    }

    redirect(stateName: string, params?: Partial<UrlParams>) {
        this.$state.go(stateName, params);
    }

    replace(params?: Partial<UrlParams>) {
        this.$state.transitionTo(this.$state.current, params, {
            location: 'replace',
            notify: false
        });
    }
}