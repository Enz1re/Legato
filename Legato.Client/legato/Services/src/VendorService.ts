import { IGuitarResource } from "../../Interfaces/interfaces";
import { IVendorService } from "../../Interfaces/interfaces";
import { ICacheService } from "../../Interfaces/interfaces";

import { ServiceBase } from "../src/ServiceBase";

import { Vendor } from "../../Models/models";


export default class VendorService extends ServiceBase implements IVendorService {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(private $q: ng.IQService, cache: ICacheService, private resource: IGuitarResource) {
        super($q, cache);
        this.$$cache = cache.create("vendorCache", 4);
    }

    getClassicalGuitarVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("classicalVendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getClassicalGuitarVendors().then(vendors => {
                this.pendingRequests--;
                this.$$cache.put("classicalVendors", vendors);
                return vendors;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }

    getWesternGuitarVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("westernVendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getWesternGuitarVendors().then(vendors => {
                this.pendingRequests--;
                this.$$cache.put("westernVendors", vendors);
                return vendors;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }

    getElectricGuitarVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("electricVendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getElectricGuitarVendors().then(vendors => {
                this.pendingRequests--;
                this.$$cache.put("electricVendors", vendors);
                return vendors;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }

    getBassGuitarVendors(): ng.IPromise<Vendor[]> {
        const cachedData = this.$$cache.get<Vendor[]>("bassVendors");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getBassGuitarVendors().then(vendors => {
                this.pendingRequests--;
                this.$$cache.put("bassVendors", vendors);
                return vendors;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }
}