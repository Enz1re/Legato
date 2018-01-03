import {
    Price,
    Vendor,
    Sorting
} from "../../Models/models";


export interface IUpdateService {
    filter: { price: Price, vendors: Vendor[], sorting: Sorting, search: string };
    updatePage: { updateCurrentPage: boolean, updateLastPage: boolean }

    replacePriceQueryParams();

    replaceVendorQueryParams();

    replaceSearchQueryParams();

    replaceSortingQueryParams();

    needUsePriceFilter(thisVal, prevVal);

    needUseVendorFilter(thisVal, prevVal);

    needSearch(thisVal, prevVal);

    needUseSorting(thisVal, prevVal);

    updateCurrentPage();

    updateLastPage();
}