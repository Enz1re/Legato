import {
    Price,
    Vendor,
    Sorting
} from "../../Models/models";


export interface IFilterUpdateService {
    filter: { price: Price, vendors: Vendor[], sorting: Sorting };

    replacePriceQueryParams(stateName: string);

    replaceVendorQueryParams(stateName: string);

    replaceSortingQueryParams(stateName: string);
}