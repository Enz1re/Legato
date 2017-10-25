import Guitar from '../../Models/Guitar';
import ClassicalGuitar from '../../Models/ClassicalGuitar';
import WesternGuitar from '../../Models/WesternGuitar';
import ElectricGuitar from '../../Models/ElectricGuitar';
import BassGuitar from '../../Models/BassGuitar';


export interface IHttpService {
    hasPendingRequests(): boolean;
    getHtmlContents(url: string): ng.IPromise<string>;

    // All guitars
    getAllGuitars(): ng.IPromise<Guitar[]>;
    getGuitarsByVendor(vendor: string): ng.IPromise<Guitar[]>;
    getGuitarsByPrice(from: number, to: number): ng.IPromise<Guitar[]>;
    // Vendors
    getAllVendors(): ng.IPromise<string[]>;
    getClassicalGuitarVendors(): ng.IPromise<string[]>;
    getWesternGuitarVendors(): ng.IPromise<string[]>;
    getElectricGuitarVendors(): ng.IPromise<string[]>;
    getBassGuitarVendors(): ng.IPromise<string[]>;
    // Classical guitars
    getAllClassicalGuitars(): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarsByVendor(vendor: string): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarsByPrice(from: number, to: number): ng.IPromise<ClassicalGuitar[]>;
    // Western guitars
    getAllWesternGuitars(): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarsByVendor(vendor: string): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarsByPrice(from: number, to: number): ng.IPromise<WesternGuitar[]>;
    // Electric guitars
    getAllElectricGuitars(): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarsByVendor(vendor: string): ng.IPromise<ElectricGuitar[]>;
    getElectricGuitarsByPrice(from: number, to: number): ng.IPromise<ElectricGuitar[]>;
    // Bass guitars
    getAllBassGuitars(): ng.IPromise<BassGuitar[]>;
    getBassGuitarsByVendor(vendor: string): ng.IPromise<BassGuitar[]>;
    getBassGuitarsByPrice(from: number, to: number): ng.IPromise<BassGuitar[]>;
}

export default IHttpService;