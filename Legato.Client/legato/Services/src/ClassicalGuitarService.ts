import {
    IGuitarResource,
    IGuitarService,
    ICacheService
} from "../../Interfaces/interfaces";

import {
    Price,
    Paging,
    Vendor,
    ClassicalGuitar
} from "../../Models/models";

import { ServiceBase } from "../src/ServiceBase";


export default class ClassicalGuitarService extends ServiceBase implements IGuitarService<ClassicalGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("classicalGuitarCache", 16);
    }

    getGuitars(searchQuery: string, price: Price, vendors: Vendor[], paging: Paging): ng.IPromise<ClassicalGuitar[]> {
        const key = this.createCacheKey(price, vendors, paging, searchQuery);
        const cachedData = this.$$cache.get<ClassicalGuitar[]>(key);
        
        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getClassicalGuitars(this.getFilter(price, vendors, searchQuery), paging).then(guitars => {
                this.pendingRequests--;
                this.$$cache.put(key, guitars);
                return guitars;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }

    getSortedGuitars(searchQuery: string, price: Price, vendors: Vendor[], paging: Paging, sortHeader: string, sortDirection: string) {
        const key = this.createCacheKey(price, paging, vendors, searchQuery, { sortHeader: sortHeader, sortDirection: sortDirection });
        const cachedData = this.$$cache.get<ClassicalGuitar[]>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getSortedClassicalGuitars(this.getFilter(price, vendors, searchQuery), paging, sortHeader, sortDirection).then(guitars => {
                this.pendingRequests--;
                this.$$cache.put(key, guitars);
                return guitars;
            }).catch(err => {
                this.pendingRequests = 0;
                throw err;
            });
        }
    }
    
    getAmount(searchQuery: string, price: Price, vendors: Vendor[]): ng.IPromise<number> {
        const key = this.createCacheKey(price, vendors, searchQuery);
        const cachedData = this.$$cache.get<number>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getClassicalGuitarQuantity(this.getFilter(price, vendors, searchQuery)).then(amount => {
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