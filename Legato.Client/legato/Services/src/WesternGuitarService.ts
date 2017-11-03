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

    getGuitars(price: Price, vendors: string[], paging: Paging): ng.IPromise<WesternGuitar[]> {
        const cachedData = this.$$cache.get<WesternGuitar[]>("guitars");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getWesternGuitars({ priceFilter: price, vendorFilter: { vendors: vendors } }, paging).then(guitars => {
                this.$$cache.put("guitars", guitars);
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