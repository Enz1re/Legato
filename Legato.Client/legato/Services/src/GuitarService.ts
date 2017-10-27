import Guitar from '../../Models/Guitar';
import ClassicalGuitar from '../../Models/ClassicalGuitar';
import WesternGuitar from '../../Models/WesternGuitar';
import ElectricGuitar from '../../Models/ElectricGuitar';
import BassGuitar from '../../Models/BassGuitar';

import { IGuitarService } from '../../interfaces/interfaces';


export default class GuitarService implements IGuitarService {
    static $inject = ['$http'];

    constructor (private $http: ng.IHttpService) {

    }

    hasPendingRequests() {
        return this.$http.pendingRequests.length > 0;
    }

    getHtmlContents(url: string): ng.IPromise<string> {
        return this.$http.get(url).then(response => response.data as string);
    }

    // All guitars
    getAllGuitars(): ng.IPromise<Guitar[]> {
        return this.$http.get("http://localhost/api/Guitars")
            .then(result => result.data as Guitar[]);
    }

    getGuitarsByVendor(vendor: string): ng.IPromise<Guitar[]> {
        return this.$http.get("http://localhost/api/Guitars", { data: { vendor: vendor } })
            .then(result => result.data as Guitar[]);
    }

    getGuitarsByPrice(from: number, to: number): ng.IPromise<Guitar[]> {
        return this.$http.get("http://localhost/api/Guitars", { data: { from: from, to: to } })
            .then(result => result.data as Guitar[]);
    }

    // Vendors
    getAllVendors(): ng.IPromise<string[]> {
        return this.$http.get("http://localhost/api/Guitars/Vendors")
            .then(result => result.data as string[]);
    }

    getClassicalGuitarVendors(): ng.IPromise<string[]> {
        return this.$http.get("http://localhost/api/Classical/Vendors")
            .then(result => result.data as string[]);
    }

    getWesternGuitarVendors(): ng.IPromise<string[]> {
        return this.$http.get("http://localhost/api/Western/Vendors")
            .then(result => result.data as string[]);
    }

    getElectricGuitarVendors(): ng.IPromise<string[]> {
        return this.$http.get("http://localhost/api/Electric/Vendors")
            .then(result => result.data as string[]);
    }

    getBassGuitarVendors(): ng.IPromise<string[]> {
        return this.$http.get("http://localhost/api/Bass/Vendors")
            .then(result => result.data as string[]);
    }

    // Classical guitars
    getAllClassicalGuitars(): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get("http://localhost/api/Classical")
            .then(result => result.data as ClassicalGuitar[]);
    }

    getClassicalGuitarsByVendor(vendor: string): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get("http://localhost/api/Classical", { data: { vendor: vendor } })
            .then(result => result.data as ClassicalGuitar[]);
    }

    getClassicalGuitarsByPrice(from: number, to: number): ng.IPromise<ClassicalGuitar[]> {
        return this.$http.get("http://localhost/api/Classical", { data: { from: from, to: to } })
            .then(result => result.data as ClassicalGuitar[]);
    }

    // Western guitars
    getAllWesternGuitars(): ng.IPromise<WesternGuitar[]> {
        return this.$http.get("http://localhost/api/Western")
            .then(result => result.data as WesternGuitar[]);
    }

    getWesternGuitarsByVendor(vendor: string): ng.IPromise<WesternGuitar[]> {
        return this.$http.get("http://localhost/api/Western", { data: { vendor: vendor } })
            .then(result => result.data as WesternGuitar[]);
    }

    getWesternGuitarsByPrice(from: number, to: number): ng.IPromise<WesternGuitar[]> {
        return this.$http.get("http://localhost/api/Western", { data: { from: from, to: to } })
            .then(result => result.data as WesternGuitar[]);
    }

    // Electric guitars
    getAllElectricGuitars(): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get("http://localhost/api/Electric")
            .then(result => result.data as ElectricGuitar[]);
    }

    getElectricGuitarsByVendor(vendor: string): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get("http://localhost/api/Electric", { data: { vendor: vendor } })
            .then(result => result.data as ElectricGuitar[]);
    }

    getElectricGuitarsByPrice(from: number, to: number): ng.IPromise<ElectricGuitar[]> {
        return this.$http.get("http://localhost/api/Electric", { data: { from: from, to: to } })
            .then(result => result.data as ElectricGuitar[]);
    }

    // Bass guitars
    getAllBassGuitars(): ng.IPromise<BassGuitar[]> {
        return this.$http.get("http://localhost/api/Bass")
            .then(result => result.data as BassGuitar[]);
    }

    getBassGuitarsByVendor(vendor: string): ng.IPromise<BassGuitar[]> {
        return this.$http.get("http://localhost/api/Bass", { data: { vendor: vendor } })
            .then(result => result.data as BassGuitar[]);
    }

    getBassGuitarsByPrice(from: number, to: number): ng.IPromise<BassGuitar[]> {
        return this.$http.get("http://localhost/api/Bass", { data: { from: from, to: to } })
            .then(result => result.data as BassGuitar[]);
    }
}
