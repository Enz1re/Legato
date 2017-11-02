import {
    IGuitarResource,
    IGuitarService,
    ICacheService
} from "../../Interfaces/interfaces";

import {
    BassGuitar,
    Paging,
    Price
} from "../../Models/models";

import { ServiceBase } from "../src/ServiceBase";


export default class BassGuitarService extends ServiceBase implements IGuitarService<BassGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("bassGuitarCache");
    }

    getAllGuitars(paging: Paging): ng.IPromise<BassGuitar[]> {
        const cachedData = this.$$cache.get<BassGuitar[]>("guitars");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getAllBassGuitars(paging).then(guitars => {
                this.$$cache.put("guitars", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByVendors(vendors: string[], paging: Paging): ng.IPromise<BassGuitar[]> {
        const cachedData = this.$$cache.get<BassGuitar[]>("guitarsByVendor");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getBassGuitarsByVendors(vendors, paging).then(guitars => {
                this.$$cache.put("guitarsByVendor", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByPrice(price: Price, paging: Paging): ng.IPromise<BassGuitar[]> {
        const cachedData = this.$$cache.get<BassGuitar[]>("guitarsByPrice");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getBassGuitarsByPrice(price, paging).then(guitars => {
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