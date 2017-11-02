import { IGuitarResource } from "../../Interfaces/interfaces";
import { IVendorService } from "../../Interfaces/interfaces";
import { ICacheService } from "../../Interfaces/interfaces";

import { ServiceBase } from "../src/ServiceBase";

import { Vendor } from "../../Models/models";


export default class VendorService extends ServiceBase implements IVendorService {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(private $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("vendorCache");
    }

    getAllVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("vendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getAllVendors().then(vendors => {
                const vendorArray = vendors.map<Vendor>(vName => { return { name: vName, isSelected: true }; });
                this.$$cache.put("vendors", vendorArray);
                return vendorArray;
            });
        }
    }

    getClassicalGuitarVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("classicalVendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getClassicalGuitarVendors().then(vendors => {
                const vendorArray = vendors.map<Vendor>(vName => { return { name: vName, isSelected: true }; });
                this.$$cache.put("classicalVendors", vendorArray);
                return vendorArray;
            });
        }
    }

    getWesternGuitarVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("westernVendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getWesternGuitarVendors().then(vendors => {
                const vendorArray = vendors.map<Vendor>(vName => { return { name: vName, isSelected: true }; });
                this.$$cache.put("westernVendors", vendorArray);
                return vendorArray;
            });
        }
    }

    getElectricGuitarVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("electricVendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getElectricGuitarVendors().then(vendors => {
                const vendorArray = vendors.map<Vendor>(vName => { return { name: vName, isSelected: true }; });
                this.$$cache.put("electricVendors", vendorArray);
                return vendorArray;
            });
        }
    }

    getBassGuitarVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("bassVendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getBassGuitarVendors().then(vendors => {
                const vendorArray = vendors.map<Vendor>(vName => { return { name: vName, isSelected: true }; });
                this.$$cache.put("bassVendors", vendorArray);
                return vendorArray;
            });
        }
    }
}