import UrlParamResolver from "../src/UrlParamResolver";

import { UrlParams } from "../../Models/models";

import { IRoutingService, IUrlParamResolver } from "../../Interfaces/interfaces";


export default class RoutingService implements IRoutingService {
    static $inject = ["$q", "$state", "$stateParams", "$location"];

    constructor(private $q: ng.IQService, private $state: ng.ui.IStateService,
                private $stateParams: ng.ui.IStateParamsService, private $location: ng.ILocationService) {

    }

    getParamResolver(): IUrlParamResolver {
        return new UrlParamResolver(this.$stateParams);
    }

    url() {
        return this.$location.url();
    }

    queryParams() {
        return this.$stateParams;
    }

    transition() {
        const deferred = this.$q.defer();
        
        if (!this.$state.transition) {
            deferred.resolve(this.$state.current.name);
            return deferred.promise;
        }

        this.$state.transition.then(() => {
            deferred.resolve(this.$state.current.name);
        }).catch(err => {
            deferred.reject(err);
        });

        return deferred.promise;
    }

    redirect(stateName: string, params?: Partial<UrlParams>) {
        this.$state.go(stateName, params);
    }

    replace(stateName: string, params?: Partial<UrlParams>) {
        this.$state.transitionTo(stateName, params, {
            location: 'replace',
            notify: false
        });
    }
}