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
        this.$$cache = cache.create("classicalGuitarCache");
    }

    getGuitars(price: Price, vendors: string[], paging: Paging): ng.IPromise<ClassicalGuitar[]> {
        const cachedData = this.$$cache.get<ClassicalGuitar[]>("guitars");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getClassicalGuitars({ priceFilter: price, vendorFilter: { vendors: vendors } }, paging).then(guitars => {
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
            return this.resource.getClassicalGuitarQuantity().then(q => {
                this.$$cache.put("guitarQuantity", q);
                return q;
            });
        }
    }
}