import {
    User,
    UserViewModel,
    CompromisedAttemptList
} from "../../Models/models";

import {
    IUserService,
    IClaimService,
    IUserResource
} from "../../Interfaces/interfaces";


export default class UserService implements IUserService {
    currentUser: User;
    static $inject = ["UserResource"];

    constructor(private resource: IUserResource) {

    }

    get authenticated() {
        return !!this.currentUser;
    }

    getUsers(lowerBound: number, upperBound: number): ng.IPromise<UserViewModel[]> {
        return this.resource.getAll(lowerBound, upperBound);
    }

    blockUser(username: string): ng.IPromise<any> {
        return this.resource.blockUserSession(username);
    }

    getCompromisedAttempts(): ng.IPromise<CompromisedAttemptList> {
        return this.resource.getCompromisedAttempts();
    }

    removeCompromisedAttempts(compromisedAttempts: number[]): ng.IPromise<any> {
        return this.resource.removeCompromisedAttempts(compromisedAttempts);
    }
}