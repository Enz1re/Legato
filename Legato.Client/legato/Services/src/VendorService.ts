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
                this.$$cache.put("vendors", vendors);
                return vendors;
            });
        }
    }

    getClassicalGuitarVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("classicalVendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getClassicalGuitarVendors().then(vendors => {
                this.$$cache.put("classicalVendors", vendors);
                return vendors;
            });
        }
    }

    getWesternGuitarVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("westernVendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getWesternGuitarVendors().then(vendors => {
                this.$$cache.put("westernVendors", vendors);
                return vendors;
            });
        }
    }

    getElectricGuitarVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("electricVendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getElectricGuitarVendors().then(vendors => {
                this.$$cache.put("electricVendors", vendors);
                return vendors;
            });
        }
    }

    getBassGuitarVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("bassVendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getBassGuitarVendors().then(vendors => {
                this.$$cache.put("bassVendors", vendors);
                return vendors;
            });
        }
    }
}