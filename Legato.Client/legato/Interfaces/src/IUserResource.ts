import { UserViewModel, CompromisedAttemptList } from "../../Models/models";


export interface IUserResource {
    getAll(): ng.IPromise<UserViewModel[]>;
    blockUserSession(username: string): ng.IPromise<any>;
    getCompromisedAttempts(): ng.IPromise<CompromisedAttemptList>;
    removeCompromisedAttempts(compromisedAttempts: number[]): ng.IPromise<any>;
}