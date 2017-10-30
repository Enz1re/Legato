import { Vendor } from "../../Models/models";


export interface IVendorService {
    getAllVendors(): ng.IPromise<Vendor[]>;

    getClassicalGuitarVendors(): ng.IPromise<Vendor[]>;

    getWesternGuitarVendors(): ng.IPromise<Vendor[]>;

    getElectricGuitarVendors(): ng.IPromise<Vendor[]>;

    getBassGuitarVendors(): ng.IPromise<Vendor[]>;
}