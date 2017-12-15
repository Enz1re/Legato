import {
    Price,
    Vendor,
    Sorting
} from "../../Models/models";


export interface IUpdateService {
    filter: { price: Price, vendors: Vendor[], sorting: Sorting, search: string };
    updatePage: { updateCurrentPage: boolean, updateLastPage: boolean }

    replacePriceQueryParams(stateName: string);

    replaceVendorQueryParams(stateName: string);

    replaceSearchQueryParams(stateName: string);

    replaceSortingQueryParams(stateName: string);

    needUsePriceFilter(thisVal, prevVal);

    needUseVendorFilter(thisVal, prevVal);

    needSearch(thisVal, prevVal);

    needUseSorting(thisVal, prevVal);

    updateCurrentPage();

    updateLastPage();
}