import { User } from "../../Models/models";


export interface IUserService {
    getUsers(): ng.IPromise<User[]>;
}