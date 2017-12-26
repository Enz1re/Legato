import { IClaimService, IUserService } from "../../Interfaces/interfaces";


export default class ClaimService implements IClaimService {
    static $inject = ["$http", "UserService"];

    constructor(private $http: ng.IHttpService, private userService: IUserService) {

    }

    canAddGuitar(): ng.IPromise<boolean> {
        return this.$http.get(`http://localhost/api/Claims/ValidateUserClaim/${this.userService.currentUser.username}/AddGuitar`)
            .then(() => true)
            .catch(err => {
                if (err.statusCode !== 401) {
                    throw err;
                } else {
                    return false;
                }
            });
    }

    canChangeDisplayAmount(): ng.IPromise<boolean> {
        return this.$http.get(`http://localhost/api/Claims/ValidateUserClaim/${this.userService.currentUser.username}/ChangeDisplayAmount`)
            .then(() => true)
            .catch(err => {
                if (err.statusCode !== 401) {
                    throw err;
                } else {
                    return false;
                }
            });
    }

    canGetUserList(): ng.IPromise<boolean> {
        return this.$http.get(`http://localhost/api/Claims/ValidateUserClaim/${this.userService.currentUser.username}/GetListOfUsers`)
            .then(() => true)
            .catch(err => {
                if (err.statusCode !== 401) {
                    throw err;
                } else {
                    return false;
                }
            });
    }

    canBlockUser(): ng.IPromise<boolean> {
        return this.$http.get(`http://localhost/api/Claims/ValidateUserClaim/${this.userService.currentUser.username}/BlockUser`)
            .then(() => true)
            .catch(err => {
                if (err.statusCode !== 401) {
                    throw err;
                } else {
                    return false;
                }
            });
    }

    canRemoveGuitar(): ng.IPromise<boolean> {
        return this.$http.get(`http://localhost/api/Claims/ValidateUserClaim/${this.userService.currentUser.username}/RemoveGuitar`)
            .then(() => true)
            .catch(err => {
                if (err.statusCode !== 401) {
                    throw err;
                } else {
                    return false;
                }
            });
    }

    canEditGuitar(): ng.IPromise<boolean> {
        return this.$http.get(`http://localhost/api/Claims/ValidateUserClaim/${this.userService.currentUser.username}/EditGuitar`)
            .then(() => true)
            .catch(err => {
                if (err.statusCode !== 401) {
                    throw err;
                } else {
                    return false;
                }
            });
    }

    canGetCompromisedAttempts(): ng.IPromise<boolean> {
        return this.$http.get(`http://localhost/api/Claims/ValidateUserClaim/${this.userService.currentUser.username}/GetCompromisedAttempts`)
            .then(() => true)
            .catch(err => {
                if (err.statusCode !== 401) {
                    throw err;
                } else {
                    return false;
                }
            });
    }

    canRemoveCompromiseAttempts(): ng.IPromise<boolean> {
        return this.$http.get(`http://localhost/api/Claims/ValidateUserClaim/${this.userService.currentUser.username}/RemoveCompromisedAttempts`)
            .then(() => true)
            .catch(err => {
                if (err.statusCode !== 401) {
                    throw err;
                } else {
                    return false;
                }
            });
    }
}