import {
    IGuitarResource,
    IGuitarService,
    ICacheService
} from "../../Interfaces/interfaces";

import {
    Price,
    Vendor,
    Filter,
    GuitarFilter,
    WesternGuitar
} from "../../Models/models";

import { ServiceBase } from "../src/ServiceBase";


export default class WesternGuitarService extends ServiceBase implements IGuitarService<WesternGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, cache: ICacheService, private resource: IGuitarResource) {
        super($q, cache);
        this.$$cache = cache.create("westernGuitarCache", 16);
    }

    getGuitars(guitarFilter: GuitarFilter, lowerBound: number, upperBound: number, useCache = true): ng.IPromise<WesternGuitar[]> {
        const key = this.createCacheKey(guitarFilter.price, guitarFilter.vendors, { lowerBound: lowerBound, upperBound: upperBound }, guitarFilter.search);
        const cachedData = this.$$cache.get<WesternGuitar[]>(key);

        if (cachedData && useCache) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getWesternGuitars(new Filter(guitarFilter), lowerBound, upperBound).then(guitars => {
                this.pendingRequests--;
                this.$$cache.put(key, guitars);
                return guitars;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }

    getSortedGuitars(guitarFilter: GuitarFilter, lowerBound: number, upperBound: number, useCache = true) {
        const key = this.createCacheKey(guitarFilter.price,
                                        { lowerBound: lowerBound, upperBound: upperBound },
                                        guitarFilter.vendors, guitarFilter.search,
                                        { sortHeader: guitarFilter.sorting.name, sortDirection: guitarFilter.sorting.direction });
        const cachedData = this.$$cache.get<WesternGuitar[]>(key);

        if (cachedData && useCache) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getSortedWesternGuitars(new Filter(guitarFilter), lowerBound, upperBound, guitarFilter.sorting.name, guitarFilter.sorting.direction).then(guitars => {
                this.pendingRequests--;
                this.$$cache.put(key, guitars);
                return guitars;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }
    
    getAmount(guitarFilter: GuitarFilter, useCache = true): ng.IPromise<number> {
        const key = this.createCacheKey(guitarFilter.price, guitarFilter.vendors, guitarFilter.search);
        const cachedData = this.$$cache.get<number>(key);

        if (cachedData && useCache) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getWesternGuitarQuantity(new Filter(guitarFilter)).then(amount => {
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