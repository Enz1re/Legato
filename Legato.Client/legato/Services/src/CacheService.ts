﻿import { ICacheService } from "../../Interfaces/interfaces";


export default class CacheService implements ICacheService {
    private instance: ng.ICacheObject;
    static $inject = ["$cacheFactory"];

    constructor(private $cacheFactory: ng.ICacheFactoryService) {

    }

    create(name: string): ng.ICacheObject {
        this.instance = this.$cacheFactory(name);
        return this.instance;
    }

    get<T>(key: string): T {
        return this.instance.get<T>(key);
    }

    put<T>(key: string, data: T) {
        this.instance.put<T>(key, data);
    }
}