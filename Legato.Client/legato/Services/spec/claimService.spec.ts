import ClaimService from "../src/ClaimService";

import { User, LegatoClaims } from "../../Models/models";

import {
    IUserService,
    IClaimService,
} from "../../Interfaces/interfaces";

let fakeUser: User = {
    username: "User"
};

const userClaims = {
    addGuitar: false,
    changeDisplayAmount: false,
    getListOfUsers: false,
    blockUser: false,
    removeGuitar: false,
    editGuitar: false,
    getCompromisedAttempts: false,
    removeCompromiseAttempts: false
};

let fakeAdmin: User = {
    username: "Admin"
};

const adminClaims = {
    addGuitar: true,
    changeDisplayAmount: false,
    getListOfUsers: false,
    blockUser: true,
    removeGuitar: true,
    editGuitar: true,
    getCompromisedAttempts: false,
    removeCompromiseAttempts: false
};

let fakeSuperuser: User = {
    username: "Superuser"
};

const superUserClaims = {
    addGuitar: true,
    changeDisplayAmount: true,
    getListOfUsers: true,
    blockUser: true,
    removeGuitar: true,
    editGuitar: true,
    getCompromisedAttempts: true,
    removeCompromiseAttempts: true
};


describe("ClaimService", () => {
    let $httpBackend: ng.IHttpBackendService;
    let claimServiceUser: IClaimService;
    let claimServiceAdmin: IClaimService;
    let claimServiceSuperuser: IClaimService;
    let userServiceUser: IUserService;
    let userServiceAdmin: IUserService;
    let userServiceSuperuser: IUserService;

    beforeEach(inject((_$http_, _$httpBackend_) => {
        $httpBackend = _$httpBackend_;

        userServiceUser = <IUserService>{
            currentUser: fakeUser,
            authenticated: true,
            getUsers: jasmine.createSpy("getUsers"),
            blockUser: jasmine.createSpy("blockUser"),
            getCompromisedAttempts: jasmine.createSpy("getCompromisedAttempts"),
            removeCompromisedAttempts: jasmine.createSpy("removeCompromisedAttempts")
        };
        userServiceAdmin = <IUserService>{
            currentUser: fakeAdmin,
            authenticated: true,
            getUsers: jasmine.createSpy("getUsers"),
            blockUser: jasmine.createSpy("blockUser"),
            getCompromisedAttempts: jasmine.createSpy("getCompromisedAttempts"),
            removeCompromisedAttempts: jasmine.createSpy("removeCompromisedAttempts")
        };
        userServiceSuperuser = <IUserService>{
            currentUser: fakeSuperuser,
            authenticated: true,
            getUsers: jasmine.createSpy("getUsers"),
            blockUser: jasmine.createSpy("blockUser"),
            getCompromisedAttempts: jasmine.createSpy("getCompromisedAttempts"),
            removeCompromisedAttempts: jasmine.createSpy("removeCompromisedAttempts")
        };

        claimServiceUser = new ClaimService(_$http_, userServiceUser);
        claimServiceAdmin = new ClaimService(_$http_, userServiceAdmin);
        claimServiceSuperuser = new ClaimService(_$http_, userServiceSuperuser);
    }));

    it("gets claims for user", done => {
        $httpBackend.whenGET(`http://localhost/api/User/${userServiceUser.currentUser.username}/Claims`)
            .respond(userClaims);
        claimServiceUser.getUserClaims().then(claims => {
            expect(claims).toEqual(userClaims);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets claims for admin", done => {
        $httpBackend.whenGET(`http://localhost/api/User/${userServiceAdmin.currentUser.username}/Claims`)
            .respond(adminClaims);
        claimServiceAdmin.getUserClaims().then(claims => {
            expect(claims).toEqual(adminClaims);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets claims for superuser", done => {
        $httpBackend.whenGET(`http://localhost/api/User/${userServiceSuperuser.currentUser.username}/Claims`)
            .respond(superUserClaims);
        claimServiceSuperuser.getUserClaims().then(claims => {
            expect(claims).toEqual(superUserClaims);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("doesn't grant admin rights to user", done => {
        $httpBackend.whenGET(`http://localhost/api/User/${userServiceUser.currentUser.username}/Claims`)
            .respond(userClaims);
        claimServiceUser.getUserClaims().then(claims => {
            expect(claimServiceUser.hasAdminRights()).toBe(false);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("grants admin rights to admin", done => {
        $httpBackend.whenGET(`http://localhost/api/User/${userServiceAdmin.currentUser.username}/Claims`)
            .respond(adminClaims);
        claimServiceAdmin.getUserClaims().then(claims => {
            expect(claimServiceAdmin.hasAdminRights()).toBe(true);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("grants admin rights to superuser", done => {
        $httpBackend.whenGET(`http://localhost/api/User/${userServiceSuperuser.currentUser.username}/Claims`)
            .respond(adminClaims);
        claimServiceSuperuser.getUserClaims().then(claims => {
            expect(claimServiceSuperuser.hasAdminRights()).toBe(true);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });
})