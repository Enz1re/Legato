import { Guitar } from "../../Models/models";


export interface IGuitarService<TGuitar extends Guitar> {
    getAllGuitars(lowerBound: number, upperBound: number): ng.IPromise<TGuitar[]>;

    getGuitarsByVendors(vendors: string[], lowerBound: number, upperBound: number): ng.IPromise<TGuitar[]>;

    getGuitarsByPrice(from: number, to: number, lowerBound: number, upperBound: number): ng.IPromise<TGuitar[]>;

    getAmount(): ng.IPromise<number>;
}