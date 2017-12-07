import {
    Price,
    Guitar,
    Paging,
    Vendor,
    Filter,
    GuitarFilter
} from "../../Models/models";

import { IService } from "../../Interfaces/interfaces";


export interface IGuitarService<TGuitar extends Guitar> extends IService {
    getGuitars(guitarFilter: GuitarFilter, lowerBound: number, upperBound: number): ng.IPromise<TGuitar[]>;

    getSortedGuitars(guitarFilter: GuitarFilter, lowerBound: number, upperBound: number): ng.IPromise<TGuitar[]>;

    getAmount(guitarFilter: GuitarFilter): ng.IPromise<number>;
}