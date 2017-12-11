import {
    Price,
    Vendor,
    Sorting
} from "../../Models/models";


export interface IUpdateService {
    update: boolean;
    filter: { price: Price, vendors: Vendor[], sorting: Sorting, search: string };

    replacePriceQueryParams(stateName: string);

    replaceVendorQueryParams(stateName: string);

    replaceSearchQueryParams(stateName: string);

    replaceSortingQueryParams(stateName: string);

    needUsePriceFilter(thisVal, prevVal);

    needUseVendorFilter(thisVal, prevVal);

    needSearch(thisVal, prevVal);

    needUseSorting(thisVal, prevVal);

    updateData();
}