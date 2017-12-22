import { UserViewModel } from "../../Models/models";


export interface IUserService {
    getUsers(): ng.IPromise<UserViewModel[]>;
    blockUser(username: string): ng.IPromise<any>;
}