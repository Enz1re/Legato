import { IGuitarResource } from "../../Interfaces/interfaces";
import { IGuitarService } from "../../Interfaces/interfaces";
import { ICacheService } from "../../Interfaces/interfaces";

import { ServiceBase } from "../src/ServiceBase";

import { ElectricGuitar } from "../../Models/models";


export default class ElectricGuitarService extends ServiceBase implements IGuitarService<ElectricGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("electricGuitarCache");
    }

    getAllGuitars(): ng.IPromise<ElectricGuitar[]> {
        const cachedData = this.$$cache.get<ElectricGuitar[]>("guitars");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getAllElectricGuitars().then(guitars => {
                this.$$cache.put("guitars", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByVendors(vendors: string[]): ng.IPromise<ElectricGuitar[]> {
        const cachedData = this.$$cache.get<ElectricGuitar[]>("guitarsByVendor");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getElectricGuitarsByVendors(vendors).then(guitars => {
                this.$$cache.put("guitarsByVendor", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByPrice(from: number, to: number): ng.IPromise<ElectricGuitar[]> {
        const cachedData = this.$$cache.get<ElectricGuitar[]>("guitarsByPrice");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getElectricGuitarsByPrice(from, to).then(guitars => {
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