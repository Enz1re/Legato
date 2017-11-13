import {
    IUrlParamResolver,
    IUrlParamResolverFactoryService
} from "../../Interfaces/interfaces";

import { UrlParamResolver } from "../../Services/services-module";


export default class UrlParamResolverFactoryService implements IUrlParamResolverFactoryService {
    static $inject = ["$stateParams"];

    constructor(private $stateParams: ng.ui.IStateParamsService) {

    }

    get(): IUrlParamResolver {
        return new UrlParamResolver(this.$stateParams);
    }
}