import {
    Guitar,
    Paging,
    Price
} from "../../Models/models";


export interface IGuitarService<TGuitar extends Guitar> {
    getGuitars(price: Price, vendors: string[], paging: Paging): ng.IPromise<TGuitar[]>;

    getAmount(): ng.IPromise<number>;
}