import {
    Price,
    Amount,
    Filter,
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
    getClassicalGuitars(filter: Filter, paging: Paging): ng.IPromise<ClassicalGuitar[]> {
        var filters = { PriceFilter: { From: 420, To: 1000 } };
        return this.$http.get(`http://localhost:63231/api/Classical/${paging.lowerBound}/${paging.upperBound}`, { params: { filterJson: JSON.stringify(filters) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    getClassicalGuitarQuantity(): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Classical/Quantity")
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Western guitars
    getWesternGuitars(filter: Filter, paging: Paging): ng.IPromise<WesternGuitar[]> {
        return this.$http.get(`http://localhost/api/Western/${paging.lowerBound}/${paging.upperBound}`, { data: { filter: filter } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getWesternGuitarQuantity(): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Western/Quantity")
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Electric guitars
    getElectricGuitars(filter: Filter, paging: Paging): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get(`http://localhost/api/Electric/${paging.lowerBound}/${paging.upperBound}`, { data: { filter: filter } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getElectricGuitarQuantity(): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Electric/Quantity")
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Bass guitars
    getBassGuitars(filter: Filter, paging: Paging): ng.IPromise<BassGuitar[]> {
        return this.$http.get(`http://localhost/api/Bass/${paging.lowerBound}/${paging.upperBound}`, { data: { filter: filter } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getBassGuitarQuantity(): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Bass/Quantity")
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }
}
