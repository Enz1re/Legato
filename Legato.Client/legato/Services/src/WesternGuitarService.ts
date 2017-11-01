import { IGuitarResource } from "../../Interfaces/interfaces";
import { IGuitarService } from "../../Interfaces/interfaces";
import { ICacheService } from "../../Interfaces/interfaces";

import { ServiceBase } from "../src/ServiceBase";

import { WesternGuitar } from "../../Models/models";


export default class WesternGuitarService extends ServiceBase implements IGuitarService<WesternGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("westernGuitarCache");
    }

    getAllGuitars(): ng.IPromise<WesternGuitar[]> {
        const cachedData = this.$$cache.get<WesternGuitar[]>("guitars");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getAllWesternGuitars().then(guitars => {
                this.$$cache.put("guitars", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByVendors(vendors: string[]): ng.IPromise<WesternGuitar[]> {
        const cachedData = this.$$cache.get<WesternGuitar[]>("guitarsByVendor");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getWesternGuitarsByVendors(vendors).then(guitars => {
                this.$$cache.put("guitarsByVendor", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByPrice(from: number, to: number): ng.IPromise<WesternGuitar[]> {
        const cachedData = this.$$cache.get<WesternGuitar[]>("guitarsByPrice");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getWesternGuitarsByPrice(from, to).then(guitars => {
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