import angular from "angular";

import AntiforgeryService from "../src/AntiforgeryService";

import { IAntiforgeryService } from "../../Interfaces/interfaces";

// fake randomly generated data
const getToken = "72B102F841A64FE5AD63699744EB9E2F";
const postToken = "BA6FA08487D0487888E30499AA1F5896";
const deleteToken = "827D01447FD844369B5D6B90F4B1A714";


describe("AntiforgeryToken", () => {
    let $httpBackend: ng.IHttpBackendService;
    let antiforgery: IAntiforgeryService;

    beforeEach(inject((_$http_, _$httpBackend_) => {
        $httpBackend = _$httpBackend_;
        antiforgery = new AntiforgeryService(_$http_);
    }));

    it("receives tokens from the server", done => {
        $httpBackend.whenGET("http://localhost/api/Manage/Tokens").respond(200, {
            antiforgeryTokenGet: getToken,
            antiforgeryTokenPost: postToken,
            antiforgeryTokenDelete: deleteToken
        });
        antiforgery.getTokens().then(() => {
            expect(antiforgery.antiforgeryTokenGet).toBe(getToken);
            expect(antiforgery.antiforgeryTokenPost).toBe(postToken);
            expect(antiforgery.antiforgeryTokenDelete).toBe(deleteToken);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });
});