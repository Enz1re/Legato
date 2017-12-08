import {
    Price,
    Filter,
    Guitar, 
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
    getClassicalGuitars(filter: Filter, lowerBound: number, upperBound: number): ng.IPromise<ClassicalGuitar[]>;
    getSortedClassicalGuitars(filter: Filter, lowerBound: number, upperBound: number, sortHeader: string, sortDirection: string): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarQuantity(filter: Filter): ng.IPromise<number>;
    // western guitars
    getWesternGuitars(filter: Filter, lowerBound: number, upperBound: number): ng.IPromise<WesternGuitar[]>;
    getSortedWesternGuitars(filter: Filter, lowerBound: number, upperBound: number, sortHeader: string, sortDirection: string): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarQuantity(filter: Filter): ng.IPromise<number>;
    // electric guitars
    getElectricGuitars(filter: Filter, lowerBound: number, upperBound: number): ng.IPromise<ElectricGuitar[]>;
    getSortedElectricGuitars(filter: Filter, lowerBound: number, upperBound: number, sortHeader: string, sortDirection: string): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarQuantity(filter: Filter): ng.IPromise<number>;
    // bass guitars
    getBassGuitars(filter: Filter, lowerBound: number, upperBound: number): ng.IPromise<BassGuitar[]>;
    getSortedBassGuitars(filter: Filter, lowerBound: number, upperBound: number, sortHeader: string, sortDirection: string): ng.IPromise<BassGuitar[]>;
    getBassGuitarQuantity(filter: Filter): ng.IPromise<number>;
    // manage
    addAcousticGuitar(guitar: Guitar);
    deleteAcousticGuitar(guitar: Guitar);
    editAcousticGuitar(guitar: Guitar);

    addWesternGuitar(guitar: Guitar);
    deleteWesternGuitar(guitar: Guitar);
    editWesternGuitar(guitar: Guitar);

    addElectricGuitar(guitar: Guitar);
    deleteElectricGuitar(guitar: Guitar);
    editElectricGuitar(guitar: Guitar);

    addBassGuitar(guitar: Guitar);
    deleteBassGuitar(guitar: Guitar);
    editBassGuitar(guitar: Guitar);
}

export default IGuitarResource;