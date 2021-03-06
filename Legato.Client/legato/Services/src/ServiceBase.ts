﻿import {
    Price,
    Vendor,
    Filter,
    VendorList
} from "../../Models/models";

import { ICacheService } from "../../Interfaces/interfaces";


export class ServiceBase {
    protected pendingRequests: number;
    protected $$cache: ng.ICacheObject;

    constructor(private qServ: ng.IQService) {
        this.pendingRequests = 0;
    }

    hasPendingRequests() {
        return this.pendingRequests > 0;
    }

    createCacheKey(...objects: any[]) {
        let key = "";

        for (let obj of objects) {
            if (obj) {
                key += JSON.stringify(obj);
            }
        }
        
        return key;
    }

    resolveCachedData<T>(cachedData: T) {
        const deferred = this.qServ.defer<T>();
        deferred.resolve(cachedData);
        return deferred.promise;
    }

    clearCache() {
        this.$$cache.removeAll();
    }
}