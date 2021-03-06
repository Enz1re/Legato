﻿import {
    IGuitarResource,
    IGuitarService,
    ICacheService
} from "../../Interfaces/interfaces";

import {
    Price,
    Vendor,
    Filter,
    BassGuitar,
    GuitarFilter
} from "../../Models/models";

import { ServiceBase } from "../src/ServiceBase";


export default class BassGuitarService extends ServiceBase implements IGuitarService<BassGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("bassGuitarCache", 16);
    }

    getGuitars(guitarFilter: GuitarFilter, lowerBound: number, upperBound: number): ng.IPromise<BassGuitar[]> {
        const key = this.createCacheKey(guitarFilter.price, guitarFilter.vendors, { lowerBound: lowerBound, upperBound: upperBound }, guitarFilter.search);
        const cachedData = this.$$cache.get<BassGuitar[]>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getBassGuitars(new Filter(guitarFilter), lowerBound, upperBound).then(guitars => {
                this.pendingRequests--;
                this.$$cache.put(key, guitars);
                return guitars;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }

    getSortedGuitars(guitarFilter: GuitarFilter, lowerBound: number, upperBound: number) {
        const key = this.createCacheKey(guitarFilter.price,
                                        { lowerBound: lowerBound, upperBound: upperBound },
                                        guitarFilter.vendors, guitarFilter.search,
                                        { sortHeader: guitarFilter.sorting.name, sortDirection: guitarFilter.sorting.direction });
        const cachedData = this.$$cache.get<BassGuitar[]>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getSortedBassGuitars(new Filter(guitarFilter), lowerBound, upperBound, guitarFilter.sorting.name, guitarFilter.sorting.direction).then(guitars => {
                this.pendingRequests--;
                this.$$cache.put(key, guitars);
                return guitars;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }
    
    getAmount(guitarFilter: GuitarFilter): ng.IPromise<number> {
        const key = this.createCacheKey(guitarFilter.price, guitarFilter.vendors, guitarFilter.search);
        const cachedData = this.$$cache.get<number>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getBassGuitarQuantity(new Filter(guitarFilter)).then(amount => {
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