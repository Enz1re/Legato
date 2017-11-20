import { UrlParams } from "../../Models/models";

import { IUrlParamResolver } from "../src/IUrlParamResolver";


export interface IRoutingService {
    url: string;
    urlSegments: string[];
    queryParams: ng.ui.IStateParamsService;

    getParamResolver(): IUrlParamResolver;

    redirect(stateName: string, params?: Partial<UrlParams>);

    replace(stateName: string, params?: Partial<UrlParams>);
}