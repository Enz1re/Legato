import {
    Price,
    Guitar, 
    Paging,
    Vendor,
    BassGuitar,
    WesternGuitar,
    ElectricGuitar,
    ClassicalGuitar
} from "../../Models/models";


export interface IGuitarResource {
    // vendors
    getAllVendors(): ng.IPromise<string[]>;
    getClassicalGuitarVendors(): ng.IPromise<string[]>;
    getWesternGuitarVendors(): ng.IPromise<string[]>;
    getElectricGuitarVendors(): ng.IPromise<string[]>;
    getBassGuitarVendors(): ng.IPromise<string[]>;
    // classical guitars
    getAllClassicalGuitars(paging: Paging): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarsByVendors(vendors: string[], paging: Paging): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarsByPrice(price: Price, paging: Paging): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarQuantity(): ng.IPromise<number>;
    // western guitars
    getAllWesternGuitars(paging: Paging): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarsByVendors(vendors: string[], paging: Paging): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarsByPrice(price: Price, paging: Paging): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarQuantity(): ng.IPromise<number>;
    // electric guitars
    getAllElectricGuitars(paging: Paging): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarsByVendors(vendors: string[], paging: Paging): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarsByPrice(price: Price, paging: Paging): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarQuantity(): ng.IPromise<number>;
    // bass guitars
    getAllBassGuitars(paging: Paging): ng.IPromise<BassGuitar[]>;
    getBassGuitarsByVendors(vendors: string[], paging: Paging): ng.IPromise<BassGuitar[]>;
    getBassGuitarsByPrice(price: Price, paging: Paging): ng.IPromise<BassGuitar[]>;
    getBassGuitarQuantity(): ng.IPromise<number>;
}

export default IGuitarResource;