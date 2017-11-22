import {
    IGuitarResource,
    IGuitarService,
    ICacheService
} from "../../Interfaces/interfaces";

import {
    Price,
    Paging,
    Vendor,
    WesternGuitar
} from "../../Models/models";

import { ServiceBase } from "../src/ServiceBase";


export default class WesternGuitarService extends ServiceBase implements IGuitarService<WesternGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("westernGuitarCache", 16);
    }

    getGuitars(price: Price, vendors: Vendor[], paging: Paging): ng.IPromise<WesternGuitar[]> {
        const key = this.createCacheKey(price, vendors, paging);
        const cachedData = this.$$cache.get<WesternGuitar[]>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getWesternGuitars(this.getFilter(price, vendors), paging).then(guitars => {
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
        const key = this.createCacheKey(price, paging, vendors, { sortHeader: sortHeader, sortDirection: sortDirection });
        const cachedData = this.$$cache.get<WesternGuitar[]>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getSortedWesternGuitars(this.getFilter(price, vendors), paging, sortHeader, sortDirection).then(guitars => {
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
            return this.resource.getWesternGuitarQuantity(this.getFilter(price, vendors)).then(amount => {
                this.pendingRequests--;
                this.$$cache.put(key, amount);
                return amount;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }
}