import { UrlParams } from "../../Models/models";

import { IUrlParamResolver } from "../src/IUrlParamResolver";


export interface IRoutingService {
    getParamResolver(): IUrlParamResolver;

    url(): string;

    transition(): ng.IPromise<any>;

    queryParams(): any;

    go(stateName: string, params?: Partial<UrlParams>);
}