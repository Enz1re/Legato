import angular from "angular";

import AuthenticationService from "../src/AuthenticationService";

import {
    ISHA1,
    IUserService,
    IClaimService,
    IAntiforgeryService,
    IAuthenticationService,
} from "../../Interfaces/interfaces";

import { User, LegatoClaims } from "../../Models/models";

let fakeToken = "4920eff7dacbaea6a6dc75d28492d0371b9ed9bc";

let fakePassword = "fakeuser";

let fakeUser: User = {
    username: "FakeUser"
};

let fakeUserClaims: LegatoClaims = {
    addGuitar: false,
    changeDisplayAmount: false,
    getListOfUsers: false,
    blockUser: false,
    removeGuitar: false,
    editGuitar: false,
    getCompromisedAttempts: false,
    removeCompromiseAttempts: false
};


describe("AuthenticationService", () => {
    let $httpBackend: ng.IHttpBackendService;
    let authServiceUnauth: IAuthenticationService;
    let authServiceAuth: IAuthenticationService;
    let sha1: ISHA1;
    let userServiceUnauthenticated: IUserService;
    let userServiceAuthenticated: IUserService;
    let antiforgery: IAntiforgeryService;
    let claimService: IClaimService;

    beforeEach(() => {
        angular.mock.module("ngCookies");
    });

    beforeEach(inject((_$q_: ng.IQService, _$http_: ng.IHttpService, _$cookies_: ng.cookies.ICookiesService, _$httpBackend_: ng.IHttpBackendService) => {
        $httpBackend = _$httpBackend_;

        sha1 = <ISHA1>{
            hash: jasmine.createSpy("hash")
        };
        userServiceUnauthenticated = <IUserService>{
            currentUser: null,
            authenticated: false,
            getUsers: jasmine.createSpy("getUsers"),
            blockUser: jasmine.createSpy("blockUser"),
            getCompromisedAttempts: jasmine.createSpy("getCompromisedAttempts"),
            removeCompromisedAttempts: jasmine.createSpy("removeCompromisedAttempts")
        };
        userServiceAuthenticated = <IUserService>{
            currentUser: fakeUser,
            authenticated: true,
            getUsers: jasmine.createSpy("getUsers"),
            blockUser: jasmine.createSpy("blockUser"),
            getCompromisedAttempts: jasmine.createSpy("getCompromisedAttempts"),
            removeCompromisedAttempts: jasmine.createSpy("removeCompromisedAttempts")
        };
        claimService = <IClaimService>{
            claims: fakeUserClaims,
            hasAdminRights: () => {
                return false;
            },
            getUserClaims: jasmine.createSpy("getUserClaims").and.callFake(() => {
                return _$q_.resolve(this.claims);
            })
        };
        antiforgery = <IAntiforgeryService>{
            antiforgeryTokenGet: "",
            antiforgeryTokenPost: "",
            antiforgeryTokenDelete: "",
            getTokens: jasmine.createSpy("getTokens").and.callFake(() => {
                return _$q_.resolve();
            })
        };

        authServiceUnauth = new AuthenticationService(_$http_, _$cookies_, userServiceUnauthenticated, sha1, claimService, antiforgery);
        authServiceAuth = new AuthenticationService(_$http_, _$cookies_, userServiceAuthenticated, sha1, claimService, antiforgery);
    }));

    it("logins user and returns fake access token", done => {
        $httpBackend.whenPOST("http://localhost/api/User/Login").respond({
            accessToken: fakeToken
        });
        authServiceUnauth.login(fakeUser.username, fakePassword).then(accessToken => {
            expect(antiforgery.getTokens).toHaveBeenCalled();
            expect(claimService.getUserClaims).toHaveBeenCalled();
            expect(accessToken).toBe(fakeToken);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets fake user by fake token", done => {
        $httpBackend.whenGET(`http://localhost/api/User/Session?accessToken=${fakeToken}`)
            .respond(fakeUser);
        authServiceUnauth.getUser(fakeToken).then(() => {
            expect(antiforgery.getTokens).toHaveBeenCalled();
            expect(userServiceUnauthenticated.currentUser).toEqual(fakeUser);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("logs off user", done => {
        $httpBackend.whenPOST("http://localhost/api/User/Logout").respond(200, {});
        authServiceAuth.logOff().then(() => {
            expect(userServiceAuthenticated.currentUser).toEqual(undefined);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });
});