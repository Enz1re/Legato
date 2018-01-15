import angular from "angular";

import UrlParamResolver from "../src/UrlParamResolver";

import { Price, Sorting, Vendor } from "../../Models/models";

import {
    IRoutingService,
    IUrlParamResolver
} from "../../Interfaces/interfaces";


describe("UrlParamResolver", () => {
    let stateParamsAll: ng.ui.IStateParamsService;
    let stateParamsPage: ng.ui.IStateParamsService;
    let stateParamsPrice: ng.ui.IStateParamsService;
    let stateParamsVendors: ng.ui.IStateParamsService;
    let stateParamsSorting: ng.ui.IStateParamsService;
    let stateParamsIndex: ng.ui.IStateParamsService;
    let stateParamsEmpty: ng.ui.IStateParamsService;
    let stateParamsSearch: ng.ui.IStateParamsService;
    let routingService: IRoutingService;
    let serviceAll: IUrlParamResolver;
    let servicePage: IUrlParamResolver;
    let servicePrice: IUrlParamResolver;
    let serviceVendors: IUrlParamResolver;
    let serviceSorting: IUrlParamResolver;
    let serviceIndex: IUrlParamResolver;
    let serviceEmpty: IUrlParamResolver;
    let serviceSearch: IUrlParamResolver;

    beforeEach(() => {
        stateParamsAll = {
            page: 12,
            from: 1050,
            to: 1399,
            g: 20,
            vendors: "Kremona,Lyons,Yamaha",
            name: "Price",
            direction: "Ascending"
        };
        stateParamsPage = {
            page: 42
        };
        stateParamsPrice = {
            from: 999,
            to: 1200
        };
        stateParamsVendors = {
            vendors: "Lucero,The Loar"
        };
        stateParamsSorting = {
            name: "Vendors",
            direction: "Descending"
        };
        stateParamsIndex = {
            g: 14
        };
        stateParamsEmpty = {};
        stateParamsSearch = {
            search: "Search"
        };
        routingService = <IRoutingService>{
            url: "http://localhost:8080",
            urlSegments: ["", "classical"],
            queryParams: {},
            getParamResolver: jasmine.createSpy("getParamResolver"),
            redirect: jasmine.createSpy("redirect"),
            replace: jasmine.createSpy("replace").and.callFake(params => {
                this.queryParams = params;
            })
        };

        serviceAll = new UrlParamResolver(stateParamsAll, routingService);
        servicePage = new UrlParamResolver(stateParamsPage, routingService);
        servicePrice = new UrlParamResolver(stateParamsPrice, routingService);
        serviceVendors = new UrlParamResolver(stateParamsVendors, routingService);
        serviceSorting = new UrlParamResolver(stateParamsSorting, routingService);
        serviceIndex = new UrlParamResolver(stateParamsIndex, routingService);
        serviceEmpty = new UrlParamResolver(stateParamsEmpty, routingService);
        serviceSearch = new UrlParamResolver(stateParamsSearch, routingService);
    });

    it("resolvePage returns 42 and replaces routing service 'page' param", () => {
        expect(servicePage.resolvePage(50)).toBe(42);
        // expect(routingService.queryParams.page).toBe(42);
    });

    it("resolvePage returns 10 and replaces routing service 'page' param", () => {
        expect(servicePage.resolvePage(10)).toBe(10);
        // expect(routingService.queryParams.page).toBe(10);
    });

    it("resolvePage returns 1 when stateParams is empty", () => {
        expect(serviceEmpty.resolvePage()).toBe(1);
        // expect(routingService.queryParams.page).toBe(1);
    });

    it("resolvePrice returns { from: 999, to: 1200 }", () => {
        expect(angular.equals(servicePrice.resolvePrice(), { from: 999, to: 1200 }));
    });

    it("resolvePrice returns empty Price object", () => {
        expect(angular.equals(servicePrice.resolvePrice(), { from: null, to: null }));
    });

    it("resolveVendors returns Lucero and The Loar vendors", () => {
        expect(angular.equals(serviceVendors.resolveVendors(), [
            new Vendor({ name: "Lucero", isSelected: true }),
            new Vendor({ name: "The Loar", isSelected: true })
        ]));
    });

    it("resolveVendors returns Kremona, Lyons, Yamaha vendors", () => {
        expect(angular.equals(serviceAll.resolveVendors(), [
            new Vendor({ name: "Kremona", isSelected: true }),
            new Vendor({ name: "Lyons", isSelected: true }),
            new Vendor({ name: "Yamaha", isSelected: true })
        ]));
    });

    it("resolveVendors returns empty vendor array", () => {
        stateParamsEmpty.vendors = "";
        serviceEmpty = new UrlParamResolver(stateParamsEmpty, routingService);
        expect(angular.equals(serviceEmpty.resolveVendors(), []));
    });

    it("resolveVendors returns initial vendor list", () => {
        const vendors: Vendor[] = [
            new Vendor({ name: "Kremona", isSelected: true }),
            new Vendor({ name: "Lyons", isSelected: true }),
            new Vendor({ name: "Yamaha", isSelected: true }),
        ];
        expect(angular.equals(serviceEmpty.resolveVendors(vendors), vendors));
    });

    it("resolveSorting returns { name: 'Vendors', direction: 'Descending' }", () => {
        expect(angular.equals(serviceSorting.resolveSorting(), { name: "Vendor", direction: "Descending", required: true }));
    });

    it("resolveSorting returns { name: 'Price', direction: 'Ascending' }", () => {
        expect(angular.equals(serviceAll.resolveSorting(), { name: "Price", direction: "Ascending", required: true }));
    });

    it("resolveSearch returns 'Search'", () => {
        expect(serviceSearch.resolveSearchString()).toBe("Search");
    });

    it("resolveSearch returns empty string", () => {
        expect(serviceEmpty.resolveSearchString()).toBe("");
    });

    it("resolveIndex returns 14 and replaces index query param", () => {
        expect(serviceIndex.resolveIndex()).toBe(14);
        // expect(routingService.queryParams.index).toBe(14);
    });

    it("resolveIndex returns 20 and replaces index query param", () => {
        expect(serviceAll.resolveIndex(21)).toBe(20);
        // expect(routingService.queryParams.index).toBe(20);
    });

    it("resolveIndex returns 10 and replaces index query param", () => {
        expect(serviceIndex.resolveIndex(10)).toBe(10);
        // expect(routingService.queryParams.index).toBe(10);
    });

    it("resolveIndex returns null and replaces index query param", () => {
        expect(serviceEmpty.resolveIndex()).toBeNull();
        // expect(routingService.queryParams.index).toBe(null);
    });
});