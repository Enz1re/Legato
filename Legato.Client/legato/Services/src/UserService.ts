import { UserViewModel } from "../../Models/models";

import {
    IUserService,
    IUserResource,
} from "../../Interfaces/interfaces";


export default class UserService implements IUserService {
    static $inject = ["UserResource"];

    constructor(private resource: IUserResource) {

    }

    getUsers(): ng.IPromise<UserViewModel[]> {
        return this.resource.getAll();
    }

    blockUser(username: string): ng.IPromise<any> {
        return this.resource.blockUserSession(username);
    }
}