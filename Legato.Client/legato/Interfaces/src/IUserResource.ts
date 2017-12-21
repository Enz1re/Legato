import { User } from "../../Models/models";


export interface IUserResource {
    getAll(): ng.IPromise<User[]>;
}