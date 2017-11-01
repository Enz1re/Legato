import { IGuitarResource } from "../../Interfaces/interfaces";
import { IGuitarService } from "../../Interfaces/interfaces";
import { ICacheService } from "../../Interfaces/interfaces";

import { ServiceBase } from "../src/ServiceBase";

import { ClassicalGuitar } from "../../Models/models";


export default class ClassicalGuitarService extends ServiceBase implements IGuitarService<ClassicalGuitar> {
    static $inject = ["$q", "CacheService", "GuitarResource"];

    constructor(protected $q: ng.IQService, private cache: ICacheService, private resource: IGuitarResource) {
        super($q);
        this.$$cache = cache.create("classicalGuitarCache");
    }

    getAllGuitars(): ng.IPromise<ClassicalGuitar[]> {
        const cachedData = this.$$cache.get<ClassicalGuitar[]>("guitars");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getAllClassicalGuitars().then(guitars => {
                this.$$cache.put("guitars", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByVendor(vendor: string): ng.IPromise<ClassicalGuitar[]> {
        const cachedData = this.$$cache.get<ClassicalGuitar[]>("guitarsByVendor");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getClassicalGuitarsByVendor(vendor).then(guitars => {
                this.$$cache.put("guitarsByVendor", guitars);
                return guitars;
            });
        }
    }

    getGuitarsByPrice(from: number, to: number): ng.IPromise<ClassicalGuitar[]> {
        const cachedData = this.$$cache.get<ClassicalGuitar[]>("guitarsByPrice");

        if (cachedData) {
            return this.resolveCachedData(cachedData);
        } else {
            return this.resource.getClassicalGuitarsByPrice(from, to).then(guitars => {
                this.$$cache.put("guitarsByPrice", guitars);
                return guitars;
            });
        }
    }
}