import { User } from "../../Models/models";


export interface IAuthenticationService {
    getUser(accessToken: string): ng.IPromise<User>
    login(username: string, password: string): ng.IPromise<string>;
    logOff(): ng.IPromise<any>;
}