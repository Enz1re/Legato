import { ICacheService } from "../../Interfaces/interfaces";


export default class CacheService implements ICacheService {
    static $inject = ["$cacheFactory"];
    private instance: ng.ICacheObject;

    constructor(private $cacheFactory: ng.ICacheFactoryService) {

    }

    create(name: string, capacity: number): ng.ICacheObject {
        this.instance = this.$cacheFactory(name, { capacity: capacity });
        return this.instance;
    }

    get<T>(key: string): T {
        return this.instance.get<T>(key);
    }

    put<T>(key: string, data: T) {
        this.instance.put<T>(key, data);
    }

    clear() {
        this.instance.removeAll();
    }
}