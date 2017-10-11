import Guitar from '../Models/Guitar';
import ClassicalGuitar from '../Models/ClassicalGuitar';
import WesternGuitar from '../Models/WesternGuitar';
import ElectroGuitar from '../Models/ElectroGuitar';
import BassGuitar from '../Models/BassGuitar';


interface IHttpService {
    // All guitars
    getAllGuitars(): ng.IPromise<Guitar[]>;
    getGuitarsByVendor(vendor: string): ng.IPromise<Guitar[]>;
    getGuitarsByPrice(from: number, to: number): ng.IPromise<Guitar[]>;
    // Classical guitars
    getAllClassicalGuitars(): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarsByVendor(vendor: string): ng.IPromise<ClassicalGuitar[]>;
    getClassicalGuitarsByPrice(from: number, to: number): ng.IPromise<ClassicalGuitar[]>;
    // Western guitars
    getAllWesternGuitars(): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarsByVendor(vendor: string): ng.IPromise<WesternGuitar[]>;
    getWesternGuitarsByPrice(from: number, to: number): ng.IPromise<WesternGuitar[]>;
    // Electro guitars
    getAllElectroGuitars(): ng.IPromise<ElectroGuitar[]>;
    getElectroGuitarsByVendor(vendor: string): ng.IPromise<ElectroGuitar[]>;
    getElectroGuitarsByPrice(from: number, to: number): ng.IPromise<ElectroGuitar[]>;
    // Bass guitars
    getAllBassGuitars(): ng.IPromise<BassGuitar[]>;
    getBassGuitarsByVendor(vendor: string): ng.IPromise<BassGuitar[]>;
    getBassGuitarsByPrice(from: number, to: number): ng.IPromise<BassGuitar[]>;
}

export default IHttpService;