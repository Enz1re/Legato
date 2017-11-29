import {
    IBase64,
    IAuthenticationService
} from "../../Interfaces/interfaces";


export default class AuthenticationService implements IAuthenticationService {
    static $inject = ["$http", "$cookies", "$rootScope", "Base64"];

    constructor(private $http: ng.IHttpService, private $cookies: ng.cookies.ICookiesService, private $rootScope, private base64: IBase64) {

    }

    login(username: string, password: string): ng.IPromise<boolean> {
        return this.$http.post("http://localhost/api/Auth/Login", { username: username, password: password })
            .then((response: ng.IHttpResponse<any>) => {
                return true;
            }).catch(err => {
                return false;
            });
    }

    setCredentials(username: string, password: string) {
        const authData = this.base64.encode(`${username}:${password}`);

        this.$rootScope.globals = {
            currentUse: {
                username: username,
                authData: authData
            }
        };

        this.$http.defaults.headers.common["Authorization"] = `Basic ${authData}`;

        const cookieExp = new Date();
        cookieExp.setDate(cookieExp.getDate() + 7);
        this.$cookies.putObject("globals", this.$rootScope.globals, { expires: cookieExp });
    }

    clearCredentials() {
        this.$rootScope.globals = {};
        this.$cookies.remove("globals");
        this.$http.defaults.headers.common.Authorization = "Basic";
    }
}