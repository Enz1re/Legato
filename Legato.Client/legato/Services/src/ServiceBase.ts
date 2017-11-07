import { Price, Paging } from "../../Models/models";


export class ServiceBase {
    protected $$cache: ng.ICacheObject;

    constructor(private qServ: ng.IQService) {
        
    }

    createCacheKey(...objects: any[]) {
        let key = "";

        for (let obj of objects) {
            key += JSON.stringify(obj);
        }
        console.log(key);
        return key;
    }

    resolveCachedData<T>(cachedData: T) {
        const deferred = this.qServ.defer<T>();
        deferred.resolve(cachedData);
        return deferred.promise;
    }
}