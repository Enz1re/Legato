import { User } from "../../Models/models";

import {
    IBase64,
    IAuthenticationService
} from "../../Interfaces/interfaces";


export default class AuthenticationService implements IAuthenticationService {
    static $inject = ["$http", "$cookies", "$rootScope", "Base64"];

    constructor(private $http: ng.IHttpService, private $cookies: ng.cookies.ICookiesService, private $rootScope, private base64: IBase64) {

    }

    login(username: string, password: string): ng.IPromise<string> {
        return this.$http({
            method: "POST",
            url: "http://localhost/api/Account/Login",
            data: { username: username, password: password }
        }).then((response: ng.IHttpResponse<any>) => {
            return response.data.accessToken;
        });
    }

    setCredentials(username: string, accessToken: string) {
        this.$rootScope.globals = {
            currentUser: {
                username: username,
                accessToken: accessToken
            }
        };
        
        this.$http.defaults.headers.common.Authorization = `Bearer ${accessToken}`;

        const cookieExp = new Date();
        cookieExp.setDate(cookieExp.getDate() + 7);
        this.$cookies.putObject("globals", this.$rootScope.globals, { expires: cookieExp });
    }

    clearCredentials() {
        delete this.$rootScope.globals.currentUser;
        this.$cookies.remove("globals");
        this.$http.defaults.headers.common.Authorization = "Bearer";
    }
}