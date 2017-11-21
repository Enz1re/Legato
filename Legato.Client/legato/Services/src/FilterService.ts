import {
    Price,
    Vendor,
    Sorting
} from "../../Models/models";

import { IFilterService } from "../../Interfaces/interfaces";


export default class FilterService implements IFilterService {
    guitarFilter: {
        [key: string]: {
            [key: string]: any
        }
    }

    constructor() {
        this.guitarFilter = {
            classical: {},
            western: {},
            electric: {},
            bass: {}
        };
    }
}