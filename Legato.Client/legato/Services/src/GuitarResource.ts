﻿import angular from 'angular';

import {
    Price,
    Amount,
    Filter,
    Guitar,
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
    getClassicalGuitars(filter: Filter, lowerBound: number, upperBound: number) {
        return this.$http.get(`http://localhost/api/Classical/${lowerBound}/${upperBound}`, { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    getSortedClassicalGuitars(filter: Filter, lowerBound: number, upperBound: number, sortHeader: string, sortDirection: string) {
        return this.$http.get(`http://localhost/api/Classical/${lowerBound}/${upperBound}/${sortHeader}/${sortDirection}`,
            { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    searchClassicalGuitars(query: string, lowerBound: number, upperBound: number) {
        return this.$http.get(`http://localhost/api/Classical/${query}/${lowerBound}/${upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ClassicalGuitar[]);
    }

    getClassicalGuitarQuantity(filter: Filter): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Classical/Quantity", { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Western guitars
    getWesternGuitars(filter: Filter, lowerBound: number, upperBound: number): ng.IPromise<WesternGuitar[]> {
        return this.$http.get(`http://localhost/api/Western/${lowerBound}/${upperBound}`, { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getSortedWesternGuitars(filter: Filter, lowerBound: number, upperBound: number, sortHeader: string, sortDirection: string) {
        return this.$http.get(`http://localhost/api/Western/${lowerBound}/${upperBound}/${sortHeader}/${sortDirection}`,
            { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    searchWesternGuitars(query: string, lowerBound: number, upperBound: number) {
        return this.$http.get(`http://localhost/api/Western/${query}/${lowerBound}/${upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as WesternGuitar[]);
    }

    getWesternGuitarQuantity(filter: Filter): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Western/Quantity", { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Electric guitars
    getElectricGuitars(filter: Filter, lowerBound: number, upperBound: number): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get(`http://localhost/api/Electric/${lowerBound}/${upperBound}`, { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getSortedElectricGuitars(filter: Filter, lowerBound: number, upperBound: number, sortHeader: string, sortDirection: string) {
        return this.$http.get(`http://localhost/api/Electric/${lowerBound}/${upperBound}/${sortHeader}/${sortDirection}`,
            { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    searchElectricGuitars(query: string, lowerBound: number, upperBound: number) {
        return this.$http.get(`http://localhost/api/Electric/${query}/${lowerBound}/${upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as ElectricGuitar[]);
    }

    getElectricGuitarQuantity(filter: Filter): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Electric/Quantity", { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    // Bass guitars
    getBassGuitars(filter: Filter, lowerBound: number, upperBound: number): ng.IPromise<BassGuitar[]> {
        return this.$http.get(`http://localhost/api/Bass/${lowerBound}/${upperBound}`, { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getSortedBassGuitars(filter: Filter, lowerBound: number, upperBound: number, sortHeader: string, sortDirection: string) {
        return this.$http.get(`http://localhost/api/Bass/${lowerBound}/${upperBound}/${sortHeader}/${sortDirection}`,
            { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    searchBassGuitars(query: string, lowerBound: number, upperBound: number) {
        return this.$http.get(`http://localhost/api/Bass/${query}/${lowerBound}/${upperBound}`)
            .then((result: ng.IHttpResponse<GuitarList>) => result.data.guitars as BassGuitar[]);
    }

    getBassGuitarQuantity(filter: Filter): ng.IPromise<number> {
        return this.$http.get("http://localhost/api/Bass/Quantity", { params: { filterJson: angular.toJson(filter) } })
            .then((result: ng.IHttpResponse<Amount>) => result.data.quantity);
    }

    /* Manage */
    // Acoustic
    addAcousticGuitar(guitar: ClassicalGuitar): ng.IPromise<any> {
        return this.$http.post("http://localhost/api/Manage/Acoustic/Add", { params: { guitarJson: angular.toJson(guitar) } })
            .then((result: ng.IHttpResponse<any>) => result.data);
    }

    deleteAcousticGuitar(guitar: ClassicalGuitar): ng.IPromise<any> {
        return this.$http.delete(`http://localhost/api/Manage/Acoustic/${guitar.id}`)
            .then((result: ng.IHttpResponse<any>) => result.data);
    }

    editAcousticGuitar(guitar: ClassicalGuitar): ng.IPromise<any> {
        return this.$http.post("http://localhost/api/Manage/Acoustic/Edit", { params: { guitarJson: angular.toJson(guitar) } })
            .then((result: ng.IHttpResponse<any>) => result.data);
    }

    // Western
    addWesternGuitar(guitar: WesternGuitar): ng.IPromise<any> {
        return this.$http.post("http://localhost/api/Manage/Western/Add", { params: { guitarJson: angular.toJson(guitar) } })
            .then((result: ng.IHttpResponse<any>) => result.data);
    }

    deleteWesternGuitar(guitar: WesternGuitar): ng.IPromise<any> {
        return this.$http.delete(`http://localhost/api/Manage/Western/${guitar.id}`)
            .then((result: ng.IHttpResponse<any>) => result.data);
    }

    editWesternGuitar(guitar: WesternGuitar): ng.IPromise<any> {
        return this.$http.post("http://localhost/api/Manage/Western/Edit", { params: { guitarJson: angular.toJson(guitar) } })
            .then((result: ng.IHttpResponse<any>) => result.data);
    }

    // Electric
    addElectricGuitar(guitar: ElectricGuitar): ng.IPromise<any> {
        return this.$http.post("http://localhost/api/Manage/Electric/Add", { params: { guitarJson: angular.toJson(guitar) } })
            .then((result: ng.IHttpResponse<any>) => result.data);
    }

    deleteElectricGuitar(guitar: ElectricGuitar): ng.IPromise<any> {
        return this.$http.delete(`http://localhost/api/Manage/Electric/${guitar.id}`)
            .then((result: ng.IHttpResponse<any>) => result.data);
    }

    editElectricGuitar(guitar: ElectricGuitar): ng.IPromise<any> {
        return this.$http.post("http://localhost/api/Manage/Electric/Edit", { params: { guitarJson: angular.toJson(guitar) } })
            .then((result: ng.IHttpResponse<any>) => result.data);
    }

    // Bass
    addBassGuitar(guitar: BassGuitar): ng.IPromise<any> {
        return this.$http.post("http://localhost/api/Manage/Bass/Add", { params: { guitarJson: angular.toJson(guitar) } })
            .then((result: ng.IHttpResponse<any>) => result.data);
    }

    deleteBassGuitar(guitar: BassGuitar): ng.IPromise<any> {
        return this.$http.delete(`http://localhost/api/Manage/Bass/${guitar.id}`)
            .then((result: ng.IHttpResponse<any>) => result.data);
    }

    editBassGuitar(guitar: BassGuitar): ng.IPromise<any> {
        return this.$http.post("http://localhost/api/Manage/Bass/Edit", { params: { guitarJson: angular.toJson(guitar) } })
            .then((result: ng.IHttpResponse<any>) => result.data);
    }
}
