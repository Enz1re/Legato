import angular from 'angular';

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
    getClassicalGuitars(filter: Filter, paging: Paging) {
        return this.$http.get(`http://localhost/api/Classical/${paging.lowerBound}/${paging.upperBound}`, { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    getSortedClassicalGuitars(filter: Filter, paging: Paging, sortHeader: string, sortDirection: string) {
        return this.$http.get(`http://localhost/api/Classical/${paging.lowerBound}/${paging.upperBound}/${sortHeader}/${sortDirection}`,
            { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    searchClassicalGuitars(query: string, paging: Paging) {
        return this.$http.get(`http://localhost/api/Classical/${query}/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    getClassicalGuitarQuantity(filter: Filter): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Classical/Quantity", { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Western guitars
    getWesternGuitars(filter: Filter, paging: Paging): ng.IPromise<WesternGuitar[]> {
        return this.$http.get(`http://localhost/api/Western/${paging.lowerBound}/${paging.upperBound}`, { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getSortedWesternGuitars(filter: Filter, paging: Paging, sortHeader: string, sortDirection: string) {
        return this.$http.get(`http://localhost/api/Western/${paging.lowerBound}/${paging.upperBound}/${sortHeader}/${sortDirection}`,
            { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    searchWesternGuitars(query: string, paging: Paging) {
        return this.$http.get(`http://localhost/api/Western/${query}/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getWesternGuitarQuantity(filter: Filter): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Western/Quantity", { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Electric guitars
    getElectricGuitars(filter: Filter, paging: Paging): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get(`http://localhost/api/Electric/${paging.lowerBound}/${paging.upperBound}`, { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getSortedElectricGuitars(filter: Filter, paging: Paging, sortHeader: string, sortDirection: string) {
        return this.$http.get(`http://localhost/api/Electric/${paging.lowerBound}/${paging.upperBound}/${sortHeader}/${sortDirection}`,
            { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    searchElectricGuitars(query: string, paging: Paging) {
        return this.$http.get(`http://localhost/api/Electric/${query}/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getElectricGuitarQuantity(filter: Filter): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Electric/Quantity", { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Bass guitars
    getBassGuitars(filter: Filter, paging: Paging): ng.IPromise<BassGuitar[]> {
        return this.$http.get(`http://localhost/api/Bass/${paging.lowerBound}/${paging.upperBound}`, { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getSortedBassGuitars(filter: Filter, paging: Paging, sortHeader: string, sortDirection: string) {
        return this.$http.get(`http://localhost/api/Bass/${paging.lowerBound}/${paging.upperBound}/${sortHeader}/${sortDirection}`,
            { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    searchBassGuitars(query: string, paging: Paging) {
        return this.$http.get(`http://localhost/api/Bass/${query}/${paging.lowerBound}/${paging.upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getBassGuitarQuantity(filter: Filter): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Bass/Quantity", { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }
}
