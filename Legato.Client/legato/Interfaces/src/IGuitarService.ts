import {
    Price,
    Guitar,
    Paging,
    Vendor
} from "../../Models/models";

import { IService } from "../../Interfaces/interfaces";


export interface IGuitarService<TGuitar extends Guitar> extends IService {
    getGuitars(price: Price, vendors: Vendor[], paging: Paging): ng.IPromise<TGuitar[]>;

    getSortedGuitars(price: Price, vendors: Vendor[], paging: Paging, sortHeader: string, sortDirection: string): ng.IPromise<TGuitar[]>;

    getAmount(price: Price, vendors: Vendor[]): ng.IPromise<number>;
}