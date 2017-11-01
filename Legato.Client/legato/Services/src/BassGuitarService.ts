import { IGuitarResource } from "../../Interfaces/interfaces";
import { IGuitarService } from "../../Interfaces/interfaces";
import { ICacheService } from "../../Interfaces/interfaces";

import { ServiceBase } from "../src/ServiceBase";

import { BassGuitar } from "../../Models/models";


export default class BassGuitarService extends ServiceBase implements IGuitarService<BassGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("bassGuitarCache");
    }

    getAllGuitars(lowerBound: number, upperBound: number): ng.IPromise<BassGuitar[]> {
        const cachedData = this.$$cache.get<BassGuitar[]>("guitars");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getAllBassGuitars().then(guitars => {
                this.$$cache.put("guitars", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByVendors(vendors: string[], lowerBound: number, upperBound: number): ng.IPromise<BassGuitar[]> {
        const cachedData = this.$$cache.get<BassGuitar[]>("guitarsByVendor");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getBassGuitarsByVendors(vendors).then(guitars => {
                this.$$cache.put("guitarsByVendor", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByPrice(from: number, to: number, lowerBound: number, upperBound: number): ng.IPromise<BassGuitar[]> {
        const cachedData = this.$$cache.get<BassGuitar[]>("guitarsByPrice");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getBassGuitarsByPrice(from, to).then(guitars => {
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
            return this.resource.getBassGuitarQuantity().then(q => {
                this.$$cache.put("guitarQuantity", q);
                return q;
            });
        }
    }
}