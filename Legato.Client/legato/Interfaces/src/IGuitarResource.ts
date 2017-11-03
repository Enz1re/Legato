import {
    Price,
    Filter,
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
    getClassicalGuitars(filter: Filter, paging: Paging): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarQuantity(): ng.IPromise<number>;
    // western guitars
    getWesternGuitars(filter: Filter,paging: Paging): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarQuantity(): ng.IPromise<number>;
    // electric guitars
    getElectricGuitars(filter: Filter,paging: Paging): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarQuantity(): ng.IPromise<number>;
    // bass guitars
    getBassGuitars(filter: Filter,paging: Paging): ng.IPromise<BassGuitar[]>;
    getBassGuitarQuantity(): ng.IPromise<number>;
}

export default IGuitarResource;