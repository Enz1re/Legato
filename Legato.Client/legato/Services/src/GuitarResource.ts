import {
    Guitar,
    ClassicalGuitar,
    WesternGuitar,
    ElectricGuitar,
    BassGuitar,
    Vendor,
    VendorList,
    GuitarList,
    Amount
} from "../../Models/models";

import { IGuitarResource } from "../../interfaces/interfaces";


export default class GuitarResource implements IGuitarResource {
    static $inject = ["$http"];

    constructor (private $http: ng.IHttpService) {

    }

    // Vendors
    getAllVendors(): ng.IPromise<Vendor[]> {
        return this.$http.get("http://localhost/api/Guitars/Vendors")
            .then((result: ng.IHttpResponse<VendorList>) => result.data.vendors as Vendor[]);
    }

    getClassicalGuitarVendors(): ng.IPromise<Vendor[]> {
        return this.$http.get("http://localhost/api/Classical/Vendors")
            .then((result: ng.IHttpResponse<VendorList>) => result.data.vendors as Vendor[]);
    }

    getWesternGuitarVendors(): ng.IPromise<Vendor[]> {
        return this.$http.get("http://localhost/api/Western/Vendors")
            .then((result: ng.IHttpResponse<VendorList>) => result.data.vendors as Vendor[]);
    }

    getElectricGuitarVendors(): ng.IPromise<Vendor[]> {
        return this.$http.get("http://localhost/api/Electric/Vendors")
            .then((result: ng.IHttpResponse<VendorList>) => result.data.vendors as Vendor[]);
    }

    getBassGuitarVendors(): ng.IPromise<Vendor[]> {
        return this.$http.get("http://localhost/api/Bass/Vendors")
            .then((result: ng.IHttpResponse<VendorList>) => result.data.vendors as Vendor[]);
    }

    // Classical guitars
    getAllClassicalGuitars(): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get("http://localhost/api/Classical")
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    getClassicalGuitarsByVendors(vendors: string[]): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get("http://localhost/api/Classical", { data: { vendors: vendors } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    getClassicalGuitarsByPrice(from: number, to: number): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get("http://localhost/api/Classical", { data: { from: from, to: to } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    getClassicalGuitarQuantity(): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Classical/Quantity")
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Western guitars
    getAllWesternGuitars(): ng.IPromise<WesternGuitar[]> {
        return this.$http.get("http://localhost/api/Western")
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getWesternGuitarsByVendors(vendors: string[]): ng.IPromise<WesternGuitar[]> {
        return this.$http.get("http://localhost/api/Western", { data: { vendors: vendors } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getWesternGuitarsByPrice(from: number, to: number): ng.IPromise<WesternGuitar[]> {
        return this.$http.get("http://localhost/api/Western", { data: { from: from, to: to } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getWesternGuitarQuantity(): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Western/Quantity")
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Electric guitars
    getAllElectricGuitars(): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get("http://localhost/api/Electric")
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getElectricGuitarsByVendors(vendors: string[]): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get("http://localhost/api/Electric", { data: { vendors: vendors } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getElectricGuitarsByPrice(from: number, to: number): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get("http://localhost/api/Electric", { data: { from: from, to: to } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getElectricGuitarQuantity(): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Electric/Quantity")
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Bass guitars
    getAllBassGuitars(): ng.IPromise<BassGuitar[]> {
        return this.$http.get("http://localhost/api/Bass")
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getBassGuitarsByVendors(vendors: string[]): ng.IPromise<BassGuitar[]> {
        return this.$http.get("http://localhost/api/Bass", { data: { vendors: vendors } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getBassGuitarsByPrice(from: number, to: number): ng.IPromise<BassGuitar[]> {
        return this.$http.get("http://localhost/api/Bass", { data: { from: from, to: to } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getBassGuitarQuantity(): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Bass/Quantity")
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }
}
