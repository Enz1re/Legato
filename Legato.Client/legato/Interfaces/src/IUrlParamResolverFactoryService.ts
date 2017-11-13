import { IUrlParamResolver } from "../src/IUrlParamResolver";


export interface IUrlParamResolverFactoryService {
    get(): IUrlParamResolver;
}