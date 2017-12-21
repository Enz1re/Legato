import { User } from "../../Models/models";

import { IUserResource } from "../../Interfaces/interfaces";


export default class UserResource implements IUserResource {
    static $inject = ["$http"];

    constructor(private $http: ng.IHttpService) {

    }

    getAll(): ng.IPromise<User[]> {

    }
}