import {
    IGuitarResource,
    IGuitarService,
    ICacheService
} from "../../Interfaces/interfaces";

import {
    Price,
    Paging,
    ElectricGuitar
} from "../../Models/models";

import { ServiceBase } from "../src/ServiceBase";


export default class ElectricGuitarService extends ServiceBase implements IGuitarService<ElectricGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("electricGuitarCache");
    }

    getAllGuitars(paging: Paging): ng.IPromise<ElectricGuitar[]> {
        const cachedData = this.$$cache.get<ElectricGuitar[]>("guitars");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getAllElectricGuitars(paging).then(guitars => {
                this.$$cache.put("guitars", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByVendors(vendors: string[], paging: Paging): ng.IPromise<ElectricGuitar[]> {
        const cachedData = this.$$cache.get<ElectricGuitar[]>("guitarsByVendor");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getElectricGuitarsByVendors(vendors, paging).then(guitars => {
                this.$$cache.put("guitarsByVendor", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByPrice(price: Price, paging: Paging): ng.IPromise<ElectricGuitar[]> {
        const cachedData = this.$$cache.get<ElectricGuitar[]>("guitarsByPrice");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getElectricGuitarsByPrice(price, paging).then(guitars => {
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
            return this.resource.getElectricGuitarQuantity().then(q => {
                this.$$cache.put("guitarQuantity", q);
                return q;
            });
        }
    }
}