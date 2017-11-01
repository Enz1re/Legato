export class ServiceBase {
    protected $$cache: ng.ICacheObject;

    constructor(private qServ: ng.IQService) {
        
    }

    resolveCachedData<T>(cachedData: T[]) {
        const deferred = this.qServ.defer<T[]>();
        deferred.resolve(cachedData);
        return deferred.promise;
    }
}