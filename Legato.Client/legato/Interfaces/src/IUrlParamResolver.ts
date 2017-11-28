import {
    Price,
    Sorting,
    Vendor
} from "../../Models/models";


export interface IUrlParamResolver {
    resolvePage(): number;

    resolvePrice(): Price;

    resolveVendors(vendorList: Vendor[]): Vendor[];

    resolveSorting(): Sorting;

    resolveSearchString(): string;

    resolveIndex(): number;
}