export interface IAuthenticationService {
    login(username: string, password: string): ng.IPromise<string>;
    logOff(): ng.IPromise<any>;
}