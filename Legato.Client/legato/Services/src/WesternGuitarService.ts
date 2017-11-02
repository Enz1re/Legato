import {
    IGuitarResource,
    IGuitarService,
    ICacheService
} from "../../Interfaces/interfaces";

import {
    Price,
    Paging,
    WesternGuitar
} from "../../Models/models";

import { ServiceBase } from "../src/ServiceBase";


export default class WesternGuitarService extends ServiceBase implements IGuitarService<WesternGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("westernGuitarCache");
    }

    getAllGuitars(paging: Paging): ng.IPromise<WesternGuitar[]> {
        const cachedData = this.$$cache.get<WesternGuitar[]>("guitars");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getAllWesternGuitars(paging).then(guitars => {
                this.$$cache.put("guitars", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByVendors(vendors: string[], paging: Paging): ng.IPromise<WesternGuitar[]> {
        const cachedData = this.$$cache.get<WesternGuitar[]>("guitarsByVendor");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getWesternGuitarsByVendors(vendors, paging).then(guitars => {
                this.$$cache.put("guitarsByVendor", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByPrice(price: Price, paging: Paging): ng.IPromise<WesternGuitar[]> {
        const cachedData = this.$$cache.get<WesternGuitar[]>("guitarsByPrice");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getWesternGuitarsByPrice(price, paging).then(guitars => {
                this.$$cache.put("guitarsByPrice", guitars);
                return guitars;
            });
        }
    }

    getAmount(): ng.IPromise<number> {
        const cachedData = this.$$cache.get<number>("guitarQuantity");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getWesternGuitarQuantity().then(q => {
                this.$$cache.put("guitarQuantity", q);
                return q;
            });
        }
    }
}