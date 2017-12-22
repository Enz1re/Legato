import { UserViewModel } from "../../Models/models";


export interface IUserResource {
    getAll(): ng.IPromise<UserViewModel[]>;
    blockUserSession(username: string): ng.IPromise<any>;
}