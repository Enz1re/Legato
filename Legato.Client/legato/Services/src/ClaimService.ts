import { LegatoClaims } from "../../Models/models";

import {
    IUserService,
    IClaimService,
} from "../../Interfaces/interfaces";


export default class ClaimService implements IClaimService {
    claims: LegatoClaims = new LegatoClaims();
    static $inject = ["$http", "UserService"];

    constructor(private $http: ng.IHttpService, private userService: IUserService) {
        
    }

    hasAdminRights() {
        return this.claims ? this.claims.addGuitar && this.claims.editGuitar && this.claims.removeGuitar && this.claims.blockUser : false;
    }

    getUserClaims() {
        return this.$http.get(`http://localhost/api/User/${this.userService.currentUser.username}/Claims`)
            .then((claims: ng.IHttpResponse<LegatoClaims>) => {
                this.claims = claims.data;
                return claims.data;
            });
    }
}