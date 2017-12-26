export interface IClaimService {
    canAddGuitar(): ng.IPromise<boolean>;
    canChangeDisplayAmount(): ng.IPromise<boolean>;
    canGetUserList(): ng.IPromise<boolean>;
    canBlockUser(): ng.IPromise<boolean>;
    canRemoveGuitar(): ng.IPromise<boolean>;
    canEditGuitar(): ng.IPromise<boolean>;
    canGetCompromisedAttempts(): ng.IPromise<boolean>;
    canRemoveCompromiseAttempts(): ng.IPromise<boolean>;
}