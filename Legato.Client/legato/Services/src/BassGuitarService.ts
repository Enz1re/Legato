import {
    IGuitarResource,
    IGuitarService,
    ICacheService
} from "../../Interfaces/interfaces";

import {
    Price,
    Paging,
    Vendor,
    BassGuitar
} from "../../Models/models";

import { ServiceBase } from "../src/ServiceBase";


export default class BassGuitarService extends ServiceBase implements IGuitarService<BassGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("bassGuitarCache", 16);
    }

    getGuitars(price: Price, vendors: Vendor[], paging: Paging): ng.IPromise<BassGuitar[]> {
        const key = this.createCacheKey(price, vendors, paging);
        const cachedData = this.$$cache.get<BassGuitar[]>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getBassGuitars({
                priceFilter: price,
                vendorFilter: { vendors: vendors.map(v => v.name) }
            }, paging).then(guitars => {
                this.pendingRequests--;
                this.$$cache.put(key, guitars);
                return guitars;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }

    getSortedGuitars(price: Price, vendors: Vendor[], paging: Paging, sortHeader: string, sortDirection: string) {
        const key = this.createCacheKey(price, paging, { sortHeader: sortHeader, sortDirection: sortDirection });
        const cachedData = this.$$cache.get<BassGuitar[]>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getSortedBassGuitars({
                priceFilter: price,
                vendorFilter: { vendors: vendors.map(v => v.name) }
            }, paging, sortHeader, sortDirection).then(guitars => {
                this.pendingRequests--;
                this.$$cache.put(key, guitars);
                return guitars;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }

    getAmount(price: Price, vendors: Vendor[]): ng.IPromise<number> {
        const key = this.createCacheKey(price, vendors);
        const cachedData = this.$$cache.get<number>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getBassGuitarQuantity({ priceFilter: price, vendorFilter: { vendors: vendors.map(v => v.name) } }).then(q => {
                this.pendingRequests--;
                this.$$cache.put(key, q);
                return q;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }
}