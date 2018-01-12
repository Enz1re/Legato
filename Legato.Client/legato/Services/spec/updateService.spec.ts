import angular from "angular";

import UpdateService from "../src/UpdateService";

import {
    Price,
    Vendor,
    Sorting
} from "../../Models/models";

import {
    IUpdateService,
    IRoutingService,
    IUrlParamResolver
} from "../../Interfaces/interfaces";


describe("UpdateService", () => {
    let service: IUpdateService;
    let mockRoutingService: IRoutingService;

    beforeEach(() => {
        mockRoutingService = <IRoutingService>{
            url: "http://localhost:8080",
            urlSegments: ["", "classical"],
            queryParams: {},
            getParamResolver: jasmine.createSpy("getParamResolver").and.returnValue(<IUrlParamResolver>{
                resolvePage: (maxPage?: number) => {
                    return 1;
                },
                resolvePrice: () => {
                    return new Price();
                },
                resolveVendors: (vendorList: Vendor[]) => {
                    return [];
                },
                resolveSorting: () => {
                    return new Sorting();
                },
                resolveSearchString: () => {
                    return "";
                },
                resolveIndex: (maxIndex?: number) => {
                    return 1;
                }
            }),
            redirect: jasmine.createSpy("redirect"),
            replace: jasmine.createSpy("replace")
        };

        service = new UpdateService(mockRoutingService);
    });

    it("replaces request string params for price: { from: 1000, to: 1399 }", () => {
        service.filter.price.from = 1000;
        service.filter.price.to = 1399;
        service.replacePriceQueryParams();
        expect(mockRoutingService.queryParams.from).toBe(1000);
        expect(mockRoutingService.queryParams.to).toBe(1399);
    });

    it("replaces request string params for vendor: null", () => {
        const vendors: Vendor[] = [
            { id: 0, name: "Vendor1", isSelected: true },
            { id: 1, name: "Vendor2", isSelected: true },
            { id: 2, name: "Vendor3", isSelected: true },
        ];
        service.filter.vendors = vendors;
        service.replaceVendorQueryParams();
        expect(mockRoutingService.queryParams.vendors).toBeNull();
    });

    it("replaces request string params for vendor: '\"\"'", () => {
        const vendors: Vendor[] = [
            { id: 0, name: "Vendor1", isSelected: false },
            { id: 1, name: "Vendor2", isSelected: false },
            { id: 2, name: "Vendor3", isSelected: false },
        ];
        service.filter.vendors = vendors;
        service.replaceVendorQueryParams();
        expect(mockRoutingService.queryParams.vendors).toBe("\"\"");
    });

    it("replaces request string params for vendors: Vendor1,Vendor2", () => {
        const vendors: Vendor[] = [
            { id: 0, name: "Vendor1", isSelected: true },
            { id: 1, name: "Vendor2", isSelected: true },
            { id: 2, name: "Vendor3", isSelected: false },
        ];
        service.filter.vendors = vendors;
        service.replaceVendorQueryParams();
        expect(mockRoutingService.queryParams.vendors).toBe("Vendor1,Vendor2");
    });

    it("replaces request string params for vendors: Vendor1,Vendor3", () => {
        const vendors: Vendor[] = [
            { id: 0, name: "Vendor1", isSelected: true },
            { id: 1, name: "Vendor2", isSelected: false },
            { id: 2, name: "Vendor3", isSelected: true },
        ];
        service.filter.vendors = vendors;
        service.replaceVendorQueryParams();
        expect(mockRoutingService.queryParams.vendors).toBe("Vendor1,Vendor3");
    });

    it("replaces request string params for vendors: Vendor1", () => {
        const vendors: Vendor[] = [
            { id: 0, name: "Vendor1", isSelected: true },
            { id: 1, name: "Vendor2", isSelected: false },
            { id: 2, name: "Vendor3", isSelected: false },
        ];
        service.filter.vendors = vendors;
        service.replaceVendorQueryParams();
        expect(mockRoutingService.queryParams.vendors).toBe("Vendor1");
    });

    it("replaces request string params for search: Search", () => {
        service.filter.search = "Search";
        service.replaceSearchQueryParams();
        expect(mockRoutingService.queryParams.search).toBe("Search");
    });

    it("replaces request string params for search: Search1 Search2 Search3", () => {
        service.filter.search = "Search1 Search2 Search3";
        service.replaceSearchQueryParams();
        expect(mockRoutingService.queryParams.search).toBe("Search1 Search2 Search3");
    });

    it("replaces request string params for sorting: { name: 'Price', direction: 'Ascending' }", () => {
        service.filter.sorting = { name: "Price", direction: "Ascending", required: true };
        service.replaceSortingQueryParams();
        expect(mockRoutingService.queryParams.name).toBe("Price");
        expect(mockRoutingService.queryParams.direction).toBe("Ascending");
    });

    it("replaces request string params for sorting: { name: 'Price', direction: 'Descending' }", () => {
        service.filter.sorting = { name: "Price", direction: "Descending", required: true };
        service.replaceSortingQueryParams();
        expect(mockRoutingService.queryParams.name).toBe("Price");
        expect(mockRoutingService.queryParams.direction).toBe("Descending");
    });

    it("replaces request string params for sorting: { name: 'Vendor' }", () => {
        service.filter.sorting = { name: "Vendor", direction: "Ascending", required: true };
        service.replaceSortingQueryParams();
        expect(mockRoutingService.queryParams.name).toBe("Vendor");
        expect(mockRoutingService.queryParams.direction).toBe(null);
    });

    it("replaces request string params for sorting: { name: 'Vendor' }", () => {
        service.filter.sorting = { name: "Vendor", direction: "Descending", required: true };
        service.replaceSortingQueryParams();
        expect(mockRoutingService.queryParams.name).toBe("Vendor");
        expect(mockRoutingService.queryParams.direction).toBe(null);
    });

    it("doesn't replace string params for sorting if 'required: false' is set", () => {
        service.filter.sorting = { name: "Vendor", direction: "Descending", required: false };
        service.replaceSortingQueryParams();
        expect(mockRoutingService.queryParams.name).toBe(null);
        expect(mockRoutingService.queryParams.direction).toBe(null);
    });

    it("needUsePriceFilter returns true", () => {
        const price1 = { price: { from: 1000, to: 1001 } };
        const price2 = { price: { from: 1000, to: 1002 } };
        expect(service.needUsePriceFilter(price1, price2)).toBe(true);
    });

    it("needUsePriceFilter returns true", () => {
        const price1 = { price: { from: 1000, to: 1001 } };
        const price2 = { price: { from: 1001, to: 1001 } };
        expect(service.needUsePriceFilter(price1, price2)).toBe(true);
    });

    it("needUsePriceFilter returns true", () => {
        const price1 = { price: { from: 1000, to: 1001 } };
        const price2 = { price: { from: 1001, to: 1002 } };
        expect(service.needUsePriceFilter(price1, price2)).toBe(true);
    });

    it("needUsePriceFilter returns false", () => {
        const price1 = { price: { from: 1000, to: 1001 } };
        const price2 = { price: { from: 1000, to: 1001 } };
        expect(service.needUsePriceFilter(price1, price2)).toBe(false);
    });

    it("needUseVendorFilter returns true", () => {
        const vendors1 = {
            vendors: [
                { id: 0, name: "Vendor1", isSelected: true },
                { id: 1, name: "Vendor2", isSelected: true },
                { id: 2, name: "Vendor3", isSelected: true },
            ]
        };
        const vendors2 = {
            vendors: [
                { id: 0, name: "Vendor1", isSelected: true },
                { id: 1, name: "Vendor2", isSelected: false },
                { id: 2, name: "Vendor3", isSelected: true },
            ]
        };
        expect(service.needUseVendorFilter(vendors1, vendors2)).toBe(true);
    });

    it("needUseVendorFilter returns true", () => {
        const vendors1 = {
            vendors: [
                { id: 0, name: "Vendor1", isSelected: true },
                { id: 1, name: "Vendor2", isSelected: true },
                { id: 2, name: "Vendor3", isSelected: true },
            ]
        };
        const vendors2 = {
            vendors: [
                { id: 0, name: "Vendor1", isSelected: true },
                { id: 1, name: "Vendor2", isSelected: false },
                { id: 2, name: "Vendor3", isSelected: false },
            ]
        };
        expect(service.needUseVendorFilter(vendors1, vendors2)).toBe(true);
    });

    it("needUseVendorFilter returns true", () => {
        const vendors1 = {
            vendors: [
                { id: 0, name: "Vendor1", isSelected: true },
                { id: 1, name: "Vendor2", isSelected: true },
                { id: 2, name: "Vendor3", isSelected: true },
            ]
        };
        const vendors2 = {
            vendors: [
                { id: 0, name: "Vendor1", isSelected: false },
                { id: 1, name: "Vendor2", isSelected: false },
                { id: 2, name: "Vendor3", isSelected: false },
            ]
        };
        expect(service.needUseVendorFilter(vendors1, vendors2)).toBe(true);
    });

    it("needUseVendorFilter returns false", () => {
        const vendors1 = {
            vendors: [
                { id: 0, name: "Vendor1", isSelected: true },
                { id: 1, name: "Vendor2", isSelected: true },
                { id: 2, name: "Vendor3", isSelected: true },
            ]
        };
        const vendors2 = {
            vendors: [
                { id: 0, name: "Vendor1", isSelected: true },
                { id: 1, name: "Vendor2", isSelected: true },
                { id: 2, name: "Vendor3", isSelected: true },
            ]
        };
        expect(service.needUseVendorFilter(vendors1, vendors2)).toBe(false);
    });

    it("needUseVendorFilter returns false", () => {
        const vendors1 = {
            vendors: [
                { id: 0, name: "Vendor1", isSelected: false },
                { id: 1, name: "Vendor2", isSelected: false },
                { id: 2, name: "Vendor3", isSelected: false },
            ]
        };
        const vendors2 = {
            vendors: [
                { id: 0, name: "Vendor1", isSelected: false },
                { id: 1, name: "Vendor2", isSelected: false },
                { id: 2, name: "Vendor3", isSelected: false },
            ]
        };
        expect(service.needUseVendorFilter(vendors1, vendors2)).toBe(false);
    });

    it("needSearch returns true", () => {
        const searchString1 = { search: "Search" };
        const searchString2 = { search: "Search2" };
        expect(service.needSearch(searchString1, searchString2)).toBe(true);
    });

    it("needSearch returns false", () => {
        const searchString1 = { search: "" };
        const searchString2 = { search: "" };
        expect(service.needSearch(searchString1, searchString2)).toBe(false);
    });

    it("needSearch returns false", () => {
        const searchString1 = { search: "Search" };
        const searchString2 = { search: "Search"};
        expect(service.needSearch(searchString1, searchString2)).toBe(false);
    });

    it("needUseSorting returns true", () => {
        const sorting1 = { sorting: { name: "Price", direction: "Ascending", required: true } };
        const sorting2 = { sorting: { name: "Price", direction: "Descending", required: true } };
        expect(service.needUseSorting(sorting1, sorting2)).toBe(true);
    });

    it("needUseSorting returns true", () => {
        const sorting1 = { sorting: { name: "Price", direction: "Ascending", required: true } };
        const sorting2 = { sorting: { name: "Vendor", direction: "Ascending", required: true } };
        expect(service.needUseSorting(sorting1, sorting2)).toBe(true);
    });

    it("needUseSorting returns true", () => {
        const sorting1 = { sorting: { name: "Price", direction: "Descending", required: true } };
        const sorting2 = { sorting: { name: "Vendor", direction: "Ascending", required: true } };
        expect(service.needUseSorting(sorting1, sorting2)).toBe(true);
    });

    it("needUseSorting returns true", () => {
        const sorting1 = { sorting: { name: "Price", direction: "Ascending", required: true } };
        const sorting2 = { sorting: { name: "Vendor", direction: "Descending", required: true } };
        expect(service.needUseSorting(sorting1, sorting2)).toBe(true);
    });

    it("needUseSorting returns false", () => {
        const sorting1 = { sorting: { name: "Price", direction: "Ascending", required: true } };
        const sorting2 = { sorting: { name: "Price", direction: "Ascending", required: true } };
        expect(service.needUseSorting(sorting1, sorting2)).toBe(false);
    });

    it("needUseSorting returns false", () => {
        const sorting1 = { sorting: { name: "Vendor", direction: "Ascending", required: true } };
        const sorting2 = { sorting: { name: "Vendor", direction: "Ascending", required: true } };
        expect(service.needUseSorting(sorting1, sorting2)).toBe(false);
    });

    it("needUseSorting returns false", () => {
        const sorting1 = { sorting: { name: "Vendor", direction: "Descending", required: true } };
        const sorting2 = { sorting: { name: "Vendor", direction: "Descending", required: true } };
        expect(service.needUseSorting(sorting1, sorting2)).toBe(false);
    });

    it("updateCurrentPage() sets updateCurrentPage from true to false", () => {
        service.updatePage.updateCurrentPage = true;
        service.updateCurrentPage();
        expect(service.updatePage.updateCurrentPage).toBe(false);
    });

    it("updateCurrentPage() sets updateCurrentPage from false to true", () => {
        service.updatePage.updateCurrentPage = false;
        service.updateCurrentPage();
        expect(service.updatePage.updateCurrentPage).toBe(true);
    });

    it("updateLastPage() sets updateCurrentPage from true to false", () => {
        service.updatePage.updateLastPage = true;
        service.updateLastPage();
        expect(service.updatePage.updateLastPage).toBe(false);
    });

    it("updateLastPage() sets updateCurrentPage from false to true", () => {
        service.updatePage.updateLastPage = false;
        service.updateLastPage();
        expect(service.updatePage.updateLastPage).toBe(true);
    });
});