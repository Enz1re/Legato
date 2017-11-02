import {
    Price,
    Amount,
    Guitar,
    Paging,
    Vendor,
    BassGuitar,
    GuitarList,
    VendorList,
    WesternGuitar,
    ElectricGuitar,
    ClassicalGuitar,
} from "../../Models/models";

import { IGuitarResource } from "../../interfaces/interfaces";


export default class GuitarResource implements IGuitarResource {
    static $inject = ["$http"];

    constructor (private $http: ng.IHttpService) {

    }

    // Vendors
    getAllVendors(): ng.IPromise<string[]> {
        return this.$http.get("http://localhost/api/Guitars/Vendors")
            .then((result: ng.IHttpResponse<VendorList>) => result.data.vendors);
    }

    getClassicalGuitarVendors(): ng.IPromise<string[]> {
        return this.$http.get("http://localhost/api/Classical/Vendors")
            .then((result: ng.IHttpResponse<VendorList>) => result.data.vendors);
    }

    getWesternGuitarVendors(): ng.IPromise<string[]> {
        return this.$http.get("http://localhost/api/Western/Vendors")
            .then((result: ng.IHttpResponse<VendorList>) => result.data.vendors);
    }

    getElectricGuitarVendors(): ng.IPromise<string[]> {
        return this.$http.get("http://localhost/api/Electric/Vendors")
            .then((result: ng.IHttpResponse<VendorList>) => result.data.vendors);
    }

    getBassGuitarVendors(): ng.IPromise<string[]> {
        return this.$http.get("http://localhost/api/Bass/Vendors")
            .then((result: ng.IHttpResponse<VendorList>) => result.data.vendors);
    }

    // Classical guitars
    getAllClassicalGuitars(paging: Paging): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get(`http://localhost/api/Classical/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    getClassicalGuitarsByVendors(vendors: string[], paging: Paging): ng.IPromise<ClassicalGuitar[]> {
        const vendorsString = vendors.toString();
        return this.$http.get(`http://localhost/api/Classical/${vendorsString}/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    getClassicalGuitarsByPrice(price: Price, paging: Paging): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get(`http://localhost/api/Classical/${price.from}/${price.to}/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    getClassicalGuitarQuantity(): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Classical/Quantity")
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Western guitars
    getAllWesternGuitars(paging: Paging): ng.IPromise<WesternGuitar[]> {
        return this.$http.get(`http://localhost/api/Western/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getWesternGuitarsByVendors(vendors: string[], paging: Paging): ng.IPromise<WesternGuitar[]> {
        const vendorsString = vendors.toString();
        return this.$http.get(`http://localhost/api/Western/${vendorsString}/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getWesternGuitarsByPrice(price: Price, paging: Paging): ng.IPromise<WesternGuitar[]> {
        return this.$http.get(`http://localhost/api/Western/${price.from}/${price.to}/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getWesternGuitarQuantity(): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Western/Quantity")
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Electric guitars
    getAllElectricGuitars(paging: Paging): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get(`http://localhost/api/Electric/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getElectricGuitarsByVendors(vendors: string[], paging: Paging): ng.IPromise<ElectricGuitar[]> {
        const vendorsString = vendors.toString();
        return this.$http.get(`http://localhost/api/Electric/${vendorsString}/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getElectricGuitarsByPrice(price: Price, paging: Paging): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get(`http://localhost/api/Electric/${price.from}/${price.to}/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getElectricGuitarQuantity(): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Electric/Quantity")
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Bass guitars
    getAllBassGuitars(paging: Paging): ng.IPromise<BassGuitar[]> {
        return this.$http.get(`http://localhost/api/Bass/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getBassGuitarsByVendors(vendors: string[], paging: Paging): ng.IPromise<BassGuitar[]> {
        const vendorsString = vendors.toString();
        return this.$http.get(`http://localhost/api/Bass/${vendorsString}/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getBassGuitarsByPrice(price: Price, paging: Paging): ng.IPromise<BassGuitar[]> {
        return this.$http.get(`http://localhost/api/Bass/${price.from}/${price.to}/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getBassGuitarQuantity(): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Bass/Quantity")
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }
}
