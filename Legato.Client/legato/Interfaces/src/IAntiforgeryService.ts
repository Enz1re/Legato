export interface IAntiforgeryService {
    antiforgeryTokenGet: string;
    antiforgeryTokenPost: string;
    antiforgeryTokenDelete: string;

    getTokens(): ng.IPromise<any>;
}