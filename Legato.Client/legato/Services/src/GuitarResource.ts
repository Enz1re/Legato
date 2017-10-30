import {
    Guitar,
    ClassicalGuitar,
    WesternGuitar,
    ElectricGuitar,
    BassGuitar,
    Vendor
} from "../../Models/models";

import { IGuitarResource } from "../../interfaces/interfaces";


export default class GuitarResource implements IGuitarResource {
    static $inject = ["$http"];

    constructor (private $http: ng.IHttpService) {

    }

    // Vendors
    getAllVendors(): ng.IPromise<Vendor[]> {
        return this.$http.get("/api/Guitars/Vendors")
            .then(result => result.data as Vendor[]);
    }

    getClassicalGuitarVendors(): ng.IPromise<Vendor[]> {
        return this.$http.get("/api/Classical/Vendors")
            .then(result => result.data as Vendor[]);
    }

    getWesternGuitarVendors(): ng.IPromise<Vendor[]> {
        return this.$http.get("/api/Western/Vendors")
            .then(result => result.data as Vendor[]);
    }

    getElectricGuitarVendors(): ng.IPromise<Vendor[]> {
        return this.$http.get("/api/Electric/Vendors")
            .then(result => result.data as Vendor[]);
    }

    getBassGuitarVendors(): ng.IPromise<Vendor[]> {
        return this.$http.get("/api/Bass/Vendors")
            .then(result => result.data as Vendor[]);
    }

    // Classical guitars
    getAllClassicalGuitars(): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get("/api/Classical")
            .then(result => result.data as ClassicalGuitar[]);
    }

    getClassicalGuitarsByVendor(vendor: string): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get("/api/Classical", { data: { vendor: vendor } })
            .then(result => result.data as ClassicalGuitar[]);
    }

    getClassicalGuitarsByPrice(from: number, to: number): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get("/api/Classical", { data: { from: from, to: to } })
            .then(result => result.data as ClassicalGuitar[]);
    }

    // Western guitars
    getAllWesternGuitars(): ng.IPromise<WesternGuitar[]> {
        return this.$http.get("/api/Western")
            .then(result => result.data as WesternGuitar[]);
    }

    getWesternGuitarsByVendor(vendor: string): ng.IPromise<WesternGuitar[]> {
        return this.$http.get("/api/Western", { data: { vendor: vendor } })
            .then(result => result.data as WesternGuitar[]);
    }

    getWesternGuitarsByPrice(from: number, to: number): ng.IPromise<WesternGuitar[]> {
        return this.$http.get("/api/Western", { data: { from: from, to: to } })
            .then(result => result.data as WesternGuitar[]);
    }

    // Electric guitars
    getAllElectricGuitars(): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get("/api/Electric")
            .then(result => result.data as ElectricGuitar[]);
    }

    getElectricGuitarsByVendor(vendor: string): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get("/api/Electric", { data: { vendor: vendor } })
            .then(result => result.data as ElectricGuitar[]);
    }

    getElectricGuitarsByPrice(from: number, to: number): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get("/api/Electric", { data: { from: from, to: to } })
            .then(result => result.data as ElectricGuitar[]);
    }

    // Bass guitars
    getAllBassGuitars(): ng.IPromise<BassGuitar[]> {
        return this.$http.get("/api/Bass")
            .then(result => result.data as BassGuitar[]);
    }

    getBassGuitarsByVendor(vendor: string): ng.IPromise<BassGuitar[]> {
        return this.$http.get("/api/Bass", { data: { vendor: vendor } })
            .then(result => result.data as BassGuitar[]);
    }

    getBassGuitarsByPrice(from: number, to: number): ng.IPromise<BassGuitar[]> {
        return this.$http.get("/api/Bass", { data: { from: from, to: to } })
            .then(result => result.data as BassGuitar[]);
    }
}
