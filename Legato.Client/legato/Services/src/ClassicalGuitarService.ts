import {
    IGuitarResource,
    IGuitarService,
    ICacheService
} from "../../Interfaces/interfaces";

import {
    Price,
    Paging,
    ClassicalGuitar
} from "../../Models/models";

import { ServiceBase } from "../src/ServiceBase";


export default class ClassicalGuitarService extends ServiceBase implements IGuitarService<ClassicalGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("classicalGuitarCache", 16);
    }

    getGuitars(price: Price, vendors: string[], paging: Paging): ng.IPromise<ClassicalGuitar[]> {
        const key = this.createCacheKey(price, vendors, paging);
        const cachedData = this.$$cache.get<ClassicalGuitar[]>(key);
        
        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getClassicalGuitars({ priceFilter: price, vendorFilter: { vendors: vendors } }, paging).then(guitars => {
                this.pendingRequests--;
                this.$$cache.put(key, guitars);
                return guitars;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }

    getSortedGuitars(price: Price, vendors: string[], paging: Paging, sortHeader: string, sortDirection: string) {
        const key = this.createCacheKey(price, paging, { sortHeader: sortHeader, sortDirection: sortDirection });
        const cachedData = this.$$cache.get<ClassicalGuitar[]>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getSortedClassicalGuitars(
                { priceFilter: price, vendorFilter: { vendors: vendors } },
                paging,
                sortHeader,
                sortDirection
            ).then(guitars => {
                this.pendingRequests--;
                this.$$cache.put(key, guitars);
                return guitars;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }

    getAmount(price: Price, vendors: string[]): ng.IPromise<number> {
        const key = this.createCacheKey(price, vendors);
        const cachedData = this.$$cache.get<number>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getClassicalGuitarQuantity({ priceFilter: price, vendorFilter: { vendors: vendors } }).then(q => {
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