import { UrlParams } from "../../Models/models";

import { IUrlParamResolver } from "../src/IUrlParamResolver";


export interface IRoutingService {
    getParamResolver(): IUrlParamResolver;

    url(): string;

    urlSegments(): string[];

    queryParams(): any;

    redirect(stateName: string, params?: Partial<UrlParams>);

    replace(stateName: string, params?: Partial<UrlParams>);
}