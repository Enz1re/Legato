import { User } from "../../Models/models";

import {
    ISHA1,
    IUserService,
    IClaimService,
    IAntiforgeryService,
    IAuthenticationService,
} from "../../Interfaces/interfaces";

import { ServiceBase } from "./ServiceBase";


export default class AuthenticationService extends ServiceBase implements IAuthenticationService {
    static $inject = ["$http", "$cookies", "UserService", "SHA1", "ClaimService", "AntiforgeryService"];

    constructor(private $http: ng.IHttpService, private $cookies: ng.cookies.ICookiesService, private userService: IUserService,
                private sha1: ISHA1, private claimService: IClaimService, private antiforgery: IAntiforgeryService) {
        super(null);
    }

    getUser(accessToken: string): ng.IPromise<User> {
        this.pendingRequests++;
        return this.$http({
            method: "GET",
            url: "http://localhost/api/User/Session",
            params: { accessToken: accessToken }
        }).then((response: ng.IHttpResponse<User>) => {
            this.pendingRequests--;
            this.userService.currentUser = response.data;
            return this.antiforgery.getTokens().then(() => {
                return response.data;
            });
        }).catch(err => {
            this.pendingRequests = 0;
            throw err;
        });
    }

    login(username: string, password: string): ng.IPromise<string> {
        this.pendingRequests++;
        return this.$http({
            method: "POST",
            url: "http://localhost/api/User/Login",
            data: { username: username, password: this.sha1.hash(password) }
        }).then((response: ng.IHttpResponse<any>) => {
            this.pendingRequests--;
            this.setCredentials(username, response.data.role, response.data.accessToken);
            return this.antiforgery.getTokens().then(() => {
                return this.claimService.getUserClaims().then(() => {
                    return response.data.accessToken;
                });
            });
        }).catch(err => {
            this.pendingRequests = 0;
            throw err;
        });
    }

    logOff() {
        this.pendingRequests++;
        return this.$http({
            method: "POST",
            url: "http://localhost/api/User/Logout",
            data: { username: this.userService.currentUser.username, accessToken: this.$cookies.getObject("globals").accessToken }
        }).then(response => {
            this.pendingRequests--;
            this.claimService.claims = {};
            return response.data;
        }).catch(err => {
            this.pendingRequests = 0;
            throw err;
        }).finally(() => {
            this.clearCredentials();
        });
    }

    private setCredentials(username: string, role: string, accessToken: string) {
        var globals = {
            currentUser: {
                username: username,
                role: role
            },
            accessToken: accessToken
        };

        this.userService.currentUser = globals.currentUser;
        this.$http.defaults.headers.common.Authorization = `Bearer ${accessToken}`;

        const cookieExp = new Date();
        cookieExp.setDate(cookieExp.getDate() + 7);
        this.$cookies.putObject("globals", globals, { expires: cookieExp });
    }

    private clearCredentials() {
        delete this.userService.currentUser;
        this.$cookies.remove("globals");
        this.$http.defaults.headers.common.Authorization = "Bearer";
    }
}