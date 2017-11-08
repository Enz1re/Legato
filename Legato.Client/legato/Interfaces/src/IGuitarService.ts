import {
    Guitar,
    Paging,
    Price
} from "../../Models/models";

import { IService } from "../../Interfaces/interfaces";


export interface IGuitarService<TGuitar extends Guitar> extends IService {
    getGuitars(price: Price, vendors: string[], paging: Paging): ng.IPromise<TGuitar[]>;

    getSortedGuitars(price: Price, vendors: string[], paging: Paging, sortHeader: string, sortDirection: string): ng.IPromise<TGuitar[]>;

    getAmount(price: Price, vendors: string[]): ng.IPromise<number>;
}