import {
    Guitar, 
    Vendor,
    BassGuitar,
    WesternGuitar,
    ElectricGuitar,
    ClassicalGuitar
} from "../../Models/models";


export interface IGuitarResource {
    // vendors
    getAllVendors(): ng.IPromise<Vendor[]>;
    getClassicalGuitarVendors(): ng.IPromise<Vendor[]>;
    getWesternGuitarVendors(): ng.IPromise<Vendor[]>;
    getElectricGuitarVendors(): ng.IPromise<Vendor[]>;
    getBassGuitarVendors(): ng.IPromise<Vendor[]>;
    // classical guitars
    getAllClassicalGuitars(): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarsByVendors(vendors: string[]): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarsByPrice(from: number, to: number): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarQuantity(): ng.IPromise<number>;
    // western guitars
    getAllWesternGuitars(): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarsByVendors(vendors: string[]): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarsByPrice(from: number, to: number): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarQuantity(): ng.IPromise<number>;
    // electric guitars
    getAllElectricGuitars(): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarsByVendors(vendors: string[]): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarsByPrice(from: number, to: number): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarQuantity(): ng.IPromise<number>;
    // bass guitars
    getAllBassGuitars(): ng.IPromise<BassGuitar[]>;
    getBassGuitarsByVendors(vendors: string[]): ng.IPromise<BassGuitar[]>;
    getBassGuitarsByPrice(from: number, to: number): ng.IPromise<BassGuitar[]>;
    getBassGuitarQuantity(): ng.IPromise<number>;
}

export default IGuitarResource;