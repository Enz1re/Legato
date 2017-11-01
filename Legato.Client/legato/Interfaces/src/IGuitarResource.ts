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
    getClassicalGuitarsByVendor(vendor: string): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarsByPrice(from: number, to: number): ng.IPromise<ClassicalGuitar[]>;
    // western guitars
    getAllWesternGuitars(): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarsByVendor(vendor: string): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarsByPrice(from: number, to: number): ng.IPromise<WesternGuitar[]>;
    // electric guitars
    getAllElectricGuitars(): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarsByVendor(vendor: string): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarsByPrice(from: number, to: number): ng.IPromise<ElectricGuitar[]>;
    // bass guitars
    getAllBassGuitars(): ng.IPromise<BassGuitar[]>;
    getBassGuitarsByVendor(vendor: string): ng.IPromise<BassGuitar[]>;
    getBassGuitarsByPrice(from: number, to: number): ng.IPromise<BassGuitar[]>;
}

export default IGuitarResource;