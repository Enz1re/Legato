import { Vendor } from "../../Models/models";
import { IService } from "../../Interfaces/interfaces";


export interface IVendorService extends IService {
    getClassicalGuitarVendors(): ng.IPromise<Vendor[]>;

    getWesternGuitarVendors(): ng.IPromise<Vendor[]>;

    getElectricGuitarVendors(): ng.IPromise<Vendor[]>;

    getBassGuitarVendors(): ng.IPromise<Vendor[]>;
}