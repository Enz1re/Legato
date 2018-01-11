import GuitarResource from "../src/GuitarResource";

import {
    Price,
    Amount,
    Filter,
    Guitar,
    Vendor,
    BassGuitar,
    GuitarList,
    VendorList,
    WesternGuitar,
    ElectricGuitar,
    ClassicalGuitar,
} from "../../Models/models";

import { IGuitarResource, IAntiforgeryService } from "../../interfaces/interfaces";

// fake randomly generated data
const getToken = "72B102F841A64FE5AD63699744EB9E2F";
const postToken = "BA6FA08487D0487888E30499AA1F5896";
const deleteToken = "827D01447FD844369B5D6B90F4B1A714";

const vendor1: Vendor = { id: 0, name: "vendor1", isSelected: false };
const vendor2: Vendor = { id: 1, name: "vendor2", isSelected: false };
const vendor3: Vendor = { id: 2, name: "vendor3", isSelected: false };
const vendor4: Vendor = { id: 3, name: "vendor4", isSelected: false };
const vendor5: Vendor = { id: 4, name: "vendor5", isSelected: false };

const fakeClassicalGuitars: ClassicalGuitar[] = [
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

const fakeWesternGuitars: WesternGuitar[] = [
    new WesternGuitar(),
    new WesternGuitar(),
    new WesternGuitar(),
    new WesternGuitar(),
    new WesternGuitar(),
    new WesternGuitar(),
    new WesternGuitar(),
    new WesternGuitar(),
    new WesternGuitar(),
    new WesternGuitar()
];

const fakeElectricGuitars: ElectricGuitar[] = [
    new ElectricGuitar(),
    new ElectricGuitar(),
    new ElectricGuitar(),
    new ElectricGuitar(),
    new ElectricGuitar(),
    new ElectricGuitar(),
    new ElectricGuitar(),
    new ElectricGuitar(),
    new ElectricGuitar(),
    new ElectricGuitar()
];

const fakeBassGuitars: BassGuitar[] = [
    new BassGuitar(),
    new BassGuitar(),
    new BassGuitar(),
    new BassGuitar(),
    new BassGuitar(),
    new BassGuitar(),
    new BassGuitar(),
    new BassGuitar(),
    new BassGuitar(),
    new BassGuitar()
];


describe("GuitarResource", () => {
    let $httpBackend: ng.IHttpBackendService;
    let resource: IGuitarResource;
    let antiforgery: IAntiforgeryService;

    beforeEach(inject((_$http_: ng.IHttpService, _$httpBackend_: ng.IHttpBackendService) => {
        $httpBackend = _$httpBackend_;

        antiforgery = <IAntiforgeryService>{
            antiforgeryTokenGet: getToken,
            antiforgeryTokenPost: postToken,
            antiforgeryTokenDelete: deleteToken,
            getTokens: jasmine.createSpy("getTokens")
        };

        resource = new GuitarResource(_$http_, antiforgery);
    }));

    it("gets classical guitar vendors", done => {
        const vendors = [vendor2, vendor3, vendor1];
        $httpBackend.whenGET("http://localhost/api/Classical/Vendors").respond({ vendors: vendors });
        resource.getClassicalGuitarVendors().then(respVendors => {
            expect(vendors).toEqual(respVendors);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets western guitar vendors", done => {
        const vendors = [vendor5, vendor2, vendor4];
        $httpBackend.whenGET("http://localhost/api/Western/Vendors").respond({ vendors: vendors });
        resource.getWesternGuitarVendors().then(respVendors => {
            expect(vendors).toEqual(respVendors);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets electric guitar vendors", done => {
        const vendors = [vendor1, vendor2, vendor5];
        $httpBackend.whenGET("http://localhost/api/Electric/Vendors").respond({ vendors: vendors });
        resource.getElectricGuitarVendors().then(respVendors => {
            expect(vendors).toEqual(respVendors);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets bass guitar vendors", done => {
        const vendors = [vendor2, vendor3, vendor4];
        $httpBackend.whenGET("http://localhost/api/Bass/Vendors").respond({ vendors: vendors });
        resource.getBassGuitarVendors().then(respVendors => {
            expect(vendors).toEqual(respVendors);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets classical guitars", done => {
        $httpBackend.whenGET("http://localhost/api/Classical/0/10?filterJson=%7B%7D").respond({ guitars: fakeClassicalGuitars });
        resource.getClassicalGuitars(<Filter>{}, 0, 10).then(guitars => {
            expect(guitars).toEqual(fakeClassicalGuitars);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets sorted classical guitars", done => {
        $httpBackend.whenGET("http://localhost/api/Classical/0/10/header/direction?filterJson=%7B%7D").respond({ guitars: fakeClassicalGuitars });
        resource.getSortedClassicalGuitars(<Filter>{}, 0, 10, "header", "direction").then(guitars => {
            expect(guitars).toEqual(fakeClassicalGuitars);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("search classical guitars", done => {
        $httpBackend.whenGET("http://localhost/api/Classical/Guitar/0/10").respond({ guitars: fakeClassicalGuitars });
        resource.searchClassicalGuitars("Guitar", 0, 10).then(guitars => {
            expect(guitars).toEqual(fakeClassicalGuitars);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets classical guitar quantity", done => {
        $httpBackend.whenGET("http://localhost/api/Classical/Quantity?filterJson=%7B%7D").respond({ quantity: 100 });
        resource.getClassicalGuitarQuantity(<Filter>{}).then(quantity => {
            expect(quantity).toEqual(100);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets western guitars", done => {
        $httpBackend.whenGET("http://localhost/api/Western/0/10?filterJson=%7B%7D").respond({ guitars: fakeWesternGuitars });
        resource.getWesternGuitars(<Filter>{}, 0, 10).then(guitars => {
            expect(guitars).toEqual(fakeWesternGuitars);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets sorted western guitars", done => {
        $httpBackend.whenGET("http://localhost/api/Western/0/10/header/direction?filterJson=%7B%7D").respond({ guitars: fakeWesternGuitars });
        resource.getSortedWesternGuitars(<Filter>{}, 0, 10, "header", "direction").then(guitars => {
            expect(guitars).toEqual(fakeWesternGuitars);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("search western guitars", done => {
        $httpBackend.whenGET("http://localhost/api/Western/Guitar/0/10").respond({ guitars: fakeWesternGuitars });
        resource.searchWesternGuitars("Guitar", 0, 10).then(guitars => {
            expect(guitars).toEqual(fakeWesternGuitars);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets western guitar quantity", done => {
        $httpBackend.whenGET("http://localhost/api/Western/Quantity?filterJson=%7B%7D").respond({ quantity: 100 });
        resource.getWesternGuitarQuantity(<Filter>{}).then(quantity => {
            expect(quantity).toEqual(100);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets electric guitars", done => {
        $httpBackend.whenGET("http://localhost/api/Electric/0/10?filterJson=%7B%7D").respond({ guitars: fakeElectricGuitars });
        resource.getElectricGuitars(<Filter>{}, 0, 10).then(guitars => {
            expect(guitars).toEqual(fakeElectricGuitars);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets sorted electric guitars", done => {
        $httpBackend.whenGET("http://localhost/api/Electric/0/10/header/direction?filterJson=%7B%7D").respond({ guitars: fakeElectricGuitars });
        resource.getSortedElectricGuitars(<Filter>{}, 0, 10, "header", "direction").then(guitars => {
            expect(guitars).toEqual(fakeElectricGuitars);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("search electric guitars", done => {
        $httpBackend.whenGET("http://localhost/api/Electric/Guitar/0/10").respond({ guitars: fakeElectricGuitars });
        resource.searchElectricGuitars("Guitar", 0, 10).then(guitars => {
            expect(guitars).toEqual(fakeElectricGuitars);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets electric guitar quantity", done => {
        $httpBackend.whenGET("http://localhost/api/Electric/Quantity?filterJson=%7B%7D").respond({ quantity: 100 });
        resource.getElectricGuitarQuantity(<Filter>{}).then(quantity => {
            expect(quantity).toEqual(100);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets bass guitars", done => {
        $httpBackend.whenGET("http://localhost/api/Bass/0/10?filterJson=%7B%7D").respond({ guitars: fakeBassGuitars });
        resource.getBassGuitars(<Filter>{}, 0, 10).then(guitars => {
            expect(guitars).toEqual(fakeBassGuitars);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets sorted bass guitars", done => {
        $httpBackend.whenGET("http://localhost/api/Bass/0/10/header/direction?filterJson=%7B%7D").respond({ guitars: fakeBassGuitars });
        resource.getSortedBassGuitars(<Filter>{}, 0, 10, "header", "direction").then(guitars => {
            expect(guitars).toEqual(fakeBassGuitars);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("search bass guitars", done => {
        $httpBackend.whenGET("http://localhost/api/Bass/Guitar/0/10").respond({ guitars: fakeBassGuitars });
        resource.searchBassGuitars("Guitar", 0, 10).then(guitars => {
            expect(guitars).toEqual(fakeBassGuitars);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });

    it("gets bass guitar quantity", done => {
        $httpBackend.whenGET("http://localhost/api/Bass/Quantity?filterJson=%7B%7D").respond({ quantity: 100 });
        resource.getBassGuitarQuantity(<Filter>{}).then(quantity => {
            expect(quantity).toEqual(100);
        }).catch(err => {
            fail(err);
        }).finally(done);
        $httpBackend.flush();
    });
});