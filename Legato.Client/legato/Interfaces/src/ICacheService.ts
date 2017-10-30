export interface ICacheService {
    create(name: string): ng.ICacheObject;

    get<T>(key: string): T;

    put<T>(key: string, data: T): void;
}