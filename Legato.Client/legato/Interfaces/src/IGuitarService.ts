import { Guitar } from "../../Models/models";


export interface IGuitarService<TGuitar extends Guitar> {
    getAllGuitars(): ng.IPromise<TGuitar[]>;

    getGuitarsByVendor(vendor: string): ng.IPromise<TGuitar[]>;

    getGuitarsByPrice(from: number, to: number): ng.IPromise<TGuitar[]>;
}