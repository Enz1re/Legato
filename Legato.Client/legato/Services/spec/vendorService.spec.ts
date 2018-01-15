import VendorService from "../src/VendorService";
import GuitarResource from "../src/GuitarResource";

import {
    ICacheService,
    IVendorService,
    IGuitarResource,
    IAntiforgeryService
} from "../../Interfaces/interfaces";

import { ServiceBase } from "../src/ServiceBase";

import { Vendor } from "../../Models/models";

const vendors: Vendor[] = [
    { id: 0, name: "Kremona", isSelected: true },
    { id: 1, name: "Lyons", isSelected: true },
    { id: 2, name: "Rogue", isSelected: true },
    { id: 3, name: "Friedman", isSelected: true },
    { id: 4, name: "Hofner", isSelected: true },
];


describe("VendorService", () => {
    let $httpBackend: ng.IHttpBackendService;
    let service: IVendorService;
    let cacheService: ICacheService;
    let guitarResource: IGuitarResource;
    let antiforgery: IAntiforgeryService;

    beforeEach(inject((_$q_: ng.IQService, _$httpBackend_: ng.IHttpBackendService, _$http_: ng.IHttpService, _$cacheFactory_: ng.ICacheFactoryService) => {
        $httpBackend = _$httpBackend_;

        cacheService = <ICacheService>{
            create: jasmine.createSpy("create").and.callFake((name: string, capacity: number) => {
                return _$cacheFactory_(name, { capacity: capacity })
            }),
            get: jasmine.createSpy("get"),
            put: jasmine.createSpy("put"),
            clear: jasmine.createSpy("clear")
        };
        antiforgery = <IAntiforgeryService>{
            antiforgeryTokenGet: "",
            antiforgeryTokenPost: "",
            antiforgeryTokenDelete: "",
            getTokens: jasmine.createSpy("getTokens").and.callFake(() => {
                const deferred = _$q_.defer();
                return deferred.promise;
            })
        };

        service = new VendorService(_$q_, cacheService, new GuitarResource(_$http_, antiforgery));
    }));

    it("gets classical guitar vendors", done => {
        $httpBackend.whenGET("http://localhost/api/Classical/Vendors").respond({ vendors: vendors });
        service.getClassicalGuitarVendors().then(guitars => {
            expect(vendors).toEqual(vendors);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets western guitar vendors", done => {
        $httpBackend.whenGET("http://localhost/api/Western/Vendors").respond({ vendors: vendors });
        service.getWesternGuitarVendors().then(guitars => {
            expect(vendors).toEqual(vendors);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets electric guitar vendors", done => {
        $httpBackend.whenGET("http://localhost/api/Electric/Vendors").respond({ vendors: vendors });
        service.getElectricGuitarVendors().then(guitars => {
            expect(vendors).toEqual(vendors);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets bass guitar vendors", done => {
        $httpBackend.whenGET("http://localhost/api/Bass/Vendors").respond({ vendors: vendors });
        service.getBassGuitarVendors().then(guitars => {
            expect(vendors).toEqual(vendors);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });
});