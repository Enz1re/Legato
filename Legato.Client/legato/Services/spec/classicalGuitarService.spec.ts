import angular from "angular";

import ClassicalGuitarService from "../src/ClassicalGuitarService";
import GuitarResource from "../src/GuitarResource";

import {
    Price,
    Vendor,
    Filter,
    GuitarFilter,
    ClassicalGuitar
} from "../../Models/models";

import {
    ICacheService,
    IGuitarService,
    IGuitarResource,
    IAntiforgeryService
} from "../../Interfaces/interfaces";

let fakeGuitars: ClassicalGuitar[] = [
    new ClassicalGuitar(),
    new ClassicalGuitar(),
    new ClassicalGuitar(),
    new ClassicalGuitar(),
    new ClassicalGuitar(),
    new ClassicalGuitar(),
    new ClassicalGuitar(),
    new ClassicalGuitar(),
    new ClassicalGuitar(),
    new ClassicalGuitar()
];

function get<T>(array: T[], howMany: number): T[] {
    let newArr = [];
    const n = howMany >= array.length ? array.length : howMany;

    for (let i = 0; i < n; i++) {
        newArr.push(array[i]);
    }

    return newArr;
}


describe("BassGuitarService", () => {
    let $httpBackend: ng.IHttpBackendService;
    let service: IGuitarService<ClassicalGuitar>;
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

        service = new ClassicalGuitarService(_$q_, cacheService, new GuitarResource(_$http_, antiforgery));
    }));

    it("gets fake guitar list 0-10", done => {
        $httpBackend.whenGET("http://localhost/api/Classical/0/10?filterJson=%7B%7D").respond({ guitars: fakeGuitars });
        service.getGuitars(<GuitarFilter>{}, 0, 10).then(guitars => {
            expect(guitars.length).toEqual(10);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets fake guitar list 0-5", done => {
        $httpBackend.whenGET("http://localhost/api/Classical/0/5?filterJson=%7B%7D").respond({ guitars: get(fakeGuitars, 5) });
        service.getGuitars(<GuitarFilter>{}, 0, 5).then(guitars => {
            expect(guitars.length).toEqual(5);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets empty fake guitar list 0-0", done => {
        $httpBackend.whenGET("http://localhost/api/Classical/0/0?filterJson=%7B%7D").respond({ guitars: get(fakeGuitars, 0) });
        service.getGuitars(<GuitarFilter>{}, 0, 0).then(guitars => {
            expect(guitars.length).toEqual(0);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });
})