import {
    Guitar,
    ClassicalGuitar,
    WesternGuitar,
    ElectricGuitar,
    BassGuitar,
    Vendor,
    VendorList,
    GuitarList
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

    getClassicalGuitarsByVendor(vendor: string): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get("http://localhost/api/Classical", { data: { vendor: vendor } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    getClassicalGuitarsByPrice(from: number, to: number): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get("http://localhost/api/Classical", { data: { from: from, to: to } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    // Western guitars
    getAllWesternGuitars(): ng.IPromise<WesternGuitar[]> {
        return this.$http.get("http://localhost/api/Western")
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getWesternGuitarsByVendor(vendor: string): ng.IPromise<WesternGuitar[]> {
        return this.$http.get("http://localhost/api/Western", { data: { vendor: vendor } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getWesternGuitarsByPrice(from: number, to: number): ng.IPromise<WesternGuitar[]> {
        return this.$http.get("http://localhost/api/Western", { data: { from: from, to: to } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    // Electric guitars
    getAllElectricGuitars(): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get("http://localhost/api/Electric")
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getElectricGuitarsByVendor(vendor: string): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get("http://localhost/api/Electric", { data: { vendor: vendor } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getElectricGuitarsByPrice(from: number, to: number): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get("http://localhost/api/Electric", { data: { from: from, to: to } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    // Bass guitars
    getAllBassGuitars(): ng.IPromise<BassGuitar[]> {
        return this.$http.get("http://localhost/api/Bass")
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getBassGuitarsByVendor(vendor: string): ng.IPromise<BassGuitar[]> {
        return this.$http.get("http://localhost/api/Bass", { data: { vendor: vendor } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getBassGuitarsByPrice(from: number, to: number): ng.IPromise<BassGuitar[]> {
        return this.$http.get("http://localhost/api/Bass", { data: { from: from, to: to } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }
}
