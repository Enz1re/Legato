import {
    Guitar,
    Paging,
    Price
} from "../../Models/models";


export interface IGuitarService<TGuitar extends Guitar> {
    getAllGuitars(paging: Paging): ng.IPromise<TGuitar[]>;

    getGuitarsByVendors(vendors: string[], paging: Paging): ng.IPromise<TGuitar[]>;

    getGuitarsByPrice(price: Price, paging: Paging): ng.IPromise<TGuitar[]>;

    getAmount(): ng.IPromise<number>;
}