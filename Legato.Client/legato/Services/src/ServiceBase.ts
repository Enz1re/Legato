import {
    Price,
    Paging,
    Vendor,
    Filter,
    VendorList
} from "../../Models/models";


export class ServiceBase {
    protected pendingRequests: number;
    protected $$cache: ng.ICacheObject;

    constructor(private qServ: ng.IQService, ) {
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

    getFilter(price: Price, vendors: Vendor[]): Filter {
        let filter = new Filter();

        if (price) {
            filter.priceFilter = price;
        }
        if (vendors) {
            filter.vendorFilter = new VendorList(vendors.filter(v => v.isSelected));
        }

        return filter;
    }
}