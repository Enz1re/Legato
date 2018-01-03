import {
    Price,
    Vendor,
    Sorting
} from "../../Models/models";

import { IFilterStateService } from "../../Interfaces/interfaces";


export default class FilterStateService implements IFilterStateService {
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