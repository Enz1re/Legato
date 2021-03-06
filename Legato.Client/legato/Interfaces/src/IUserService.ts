﻿import {
    User,
    UserViewModel,
    CompromisedAttemptList
} from "../../Models/models";


export interface IUserService {
    currentUser: User;
    authenticated: boolean;

    getUsers(lowerBound: number, upperBound: number): ng.IPromise<UserViewModel[]>;
    blockUser(username: string): ng.IPromise<any>;
    getCompromisedAttempts(): ng.IPromise<CompromisedAttemptList>;
    removeCompromisedAttempts(compromisedAttempts: number[]): ng.IPromise<any>;
}