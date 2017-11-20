import {
    Price,
    Vendor,
    Sorting
} from "../../Models/models";


export interface IFilterService {
    guitarFilter: {
        [key: string]: any
    }
}