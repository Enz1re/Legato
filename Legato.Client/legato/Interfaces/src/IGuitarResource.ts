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
    getSortedClassicalGuitars(filter: Filter, paging: Paging, sortHeader: string, sortDirection: string): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarQuantity(filter: Filter): ng.IPromise<number>;
    // western guitars
    getWesternGuitars(filter: Filter, paging: Paging): ng.IPromise<WesternGuitar[]>;
    getSortedWesternGuitars(filter: Filter, paging: Paging, sortHeader: string, sortDirection: string): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarQuantity(filter: Filter): ng.IPromise<number>;
    // electric guitars
    getElectricGuitars(filter: Filter, paging: Paging): ng.IPromise<ElectricGuitar[]>;
    getSortedElectricGuitars(filter: Filter, paging: Paging, sortHeader: string, sortDirection: string): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarQuantity(filter: Filter): ng.IPromise<number>;
    // bass guitars
    getBassGuitars(filter: Filter, paging: Paging): ng.IPromise<BassGuitar[]>;
    getSortedBassGuitars(filter: Filter, paging: Paging, sortHeader: string, sortDirection: string): ng.IPromise<BassGuitar[]>;
    getBassGuitarQuantity(filter: Filter): ng.IPromise<number>;
    // manage
    add(guitar: Guitar): ng.IPromise<any>;
    delete(guitar: Guitar): ng.IPromise<any>;
    edit(guitar: Guitar): ng.IPromise<any>;
}

export default IGuitarResource;