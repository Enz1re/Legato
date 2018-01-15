import {
    Price,
    Sorting,
    Vendor
} from "../../Models/models";


export interface IUrlParamResolver {
    resolvePage(maxPage?: number): number;

    resolvePrice(): Price;

    resolveVendors(vendorList?: Vendor[]): Vendor[];

    resolveSorting(): Sorting;

    resolveSearchString(): string;

    resolveIndex(maxIndex?: number): number;
}