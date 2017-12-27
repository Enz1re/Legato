import {
    UserList,
    UserViewModel,
    CompromisedAttemptList
} from "../../Models/models";

import { IUserResource } from "../../Interfaces/interfaces";


export default class UserResource implements IUserResource {
    static $inject = ["$http"];

    constructor(private $http: ng.IHttpService) {

    }

    getAll(): ng.IPromise<UserViewModel[]> {
        return this.$http.get(`http://localhost/api/User/GetAll`)
            .then((response: ng.IHttpResponse<UserList>) => response.data.users);
    }

    blockUserSession(username: string): ng.IPromise<any> {
        return this.$http.post(`http://localhost/api/User/Block`, { username: username })
            .then((response: ng.IHttpResponse<any>) => response.data);
    }

    getCompromisedAttempts(): ng.IPromise<CompromisedAttemptList> {
        return this.$http.get("http://localhost/api/User/CompromisedAttempts")
            .then((response: ng.IHttpResponse<CompromisedAttemptList>) => response.data);
    }

    removeCompromisedAttempts(compromisedAttempts: number[]): ng.IPromise<any> {
        return this.$http.post(`http://localhost/api/User/RemoveCompromisedAttempts`, { compromisedAttempts: compromisedAttempts })
            .then((response: ng.IHttpResponse<any>) => response.data);
    }
}