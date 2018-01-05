import {
    UserList,
    UserViewModel,
    CompromisedAttemptList
} from "../../Models/models";

import { IUserResource, IAntiforgeryService } from "../../Interfaces/interfaces";


export default class UserResource implements IUserResource {
    static $inject = ["$http", "AntiforgeryService"];

    constructor(private $http: ng.IHttpService, private antiforgery: IAntiforgeryService) {

    }

    getAll(lowerBound: number, upperBound: number): ng.IPromise<UserViewModel[]> {
        return this.$http.get(`http://localhost/api/User/GetAll/${lowerBound}/${upperBound}`, { params: { antiforgeryToken: this.antiforgery.antiforgeryTokenGet } })
            .then((response: ng.IHttpResponse<UserList>) => response.data.users);
    }

    blockUserSession(username: string): ng.IPromise<any> {
        return this.$http.post(`http://localhost/api/User/Block`, { username: username, antiforgeryToken: this.antiforgery.antiforgeryTokenPost })
            .then((response: ng.IHttpResponse<any>) => response.data);
    }

    getCompromisedAttempts(): ng.IPromise<CompromisedAttemptList> {
        return this.$http.get("http://localhost/api/User/CompromisedAttempts", { params: { antiforgeryToken: this.antiforgery.antiforgeryTokenGet } })
            .then((response: ng.IHttpResponse<CompromisedAttemptList>) => response.data);
    }

    removeCompromisedAttempts(compromisedAttempts: number[]): ng.IPromise<any> {
        return this.$http.post(`http://localhost/api/User/RemoveCompromisedAttempts`, { compromisedAttempts: compromisedAttempts, antiforgeryToken: this.antiforgery.antiforgeryTokenPost })
            .then((response: ng.IHttpResponse<any>) => response.data);
    }
}