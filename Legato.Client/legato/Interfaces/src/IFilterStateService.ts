import {
    Price,
    Vendor,
    Sorting
} from "../../Models/models";


export interface IFilterStateService {
    guitarFilter: {
        [key: string]: any
    }
}