import { User } from "../../Models/models";

import { IUserService } from "../../Interfaces/interfaces";


export default class UserService implements IUserService {
    getUsers(): ng.IPromise<User[]> {

    }
}