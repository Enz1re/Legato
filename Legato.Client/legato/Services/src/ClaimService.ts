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

    getUserClaims() {
        return this.$http.get(`http://localhost/api/User/${this.userService.currentUser.username}/Claims`)
            .then((claims: ng.IHttpResponse<any>) => {
                console.log(claims);
                for (let claim of claims.data.userClaims) {
                    this.claims[claim] = true;
                }
            });
    }
}