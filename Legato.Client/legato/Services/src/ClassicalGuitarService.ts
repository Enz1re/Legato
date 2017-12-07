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
    ClassicalGuitar
} from "../../Models/models";

import { ServiceBase } from "../src/ServiceBase";


export default class ClassicalGuitarService extends ServiceBase implements IGuitarService<ClassicalGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("classicalGuitarCache", 16);
    }

    getGuitars(guitarFilter: GuitarFilter, lowerBound: number, upperBound: number): ng.IPromise<ClassicalGuitar[]> {
        const key = this.createCacheKey(guitarFilter.price, guitarFilter.vendors, { lowerBound: lowerBound, upperBound: upperBound }, guitarFilter.search);
        const cachedData = this.$$cache.get<ClassicalGuitar[]>(key);
        
        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getClassicalGuitars(new Filter(guitarFilter), lowerBound, upperBound).then(guitars => {
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
        const cachedData = this.$$cache.get<ClassicalGuitar[]>(key);

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            this.pendingRequests++;
            return this.resource.getSortedClassicalGuitars(new Filter(guitarFilter), lowerBound, upperBound, guitarFilter.sorting.name, guitarFilter.sorting.direction).then(guitars => {
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
            return this.resource.getClassicalGuitarQuantity(new Filter(guitarFilter)).then(amount => {
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