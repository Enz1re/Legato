import PagingService from "../src/PagingService";

import {
    Price,
    Vendor,
    Sorting
} from "../../Models/models";

import {
    IManageService,
    IPagingService,
    IRoutingService,
    IUrlParamResolver
} from "../../Interfaces/interfaces";

const displayAmount = 20;


describe("PagingService", () => {
    let service: IPagingService;
    let manageService: IManageService;
    let routingService: IRoutingService;

    beforeEach(inject((_$q_: ng.IQService) => {
        manageService = <IManageService>{
            addGuitar: jasmine.createSpy("addGuitar"),
            removeGuitar: jasmine.createSpy("removeGuitar"),
            editGuitarCharacteristics: jasmine.createSpy("editGuitarCharacteristics"),
            getDisplayAmount: jasmine.createSpy("getDisplayAmount").and.returnValue(_$q_.resolve(displayAmount)),
            changeDisplayAmount: jasmine.createSpy("changeDisplayAmount")
        };
        routingService = <IRoutingService>{
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

        service = new PagingService(manageService, routingService);
    }));

    it("initializes itemsToShow, lowerBound and upperBound with default values", done => {
        service.init().then(() => {
            expect(service.itemsToShow).toBe(displayAmount);
            expect(service.lowerBound).toBe(0);
            expect(service.upperBound).toBe(displayAmount);
        }).catch(err => {
            fail(err);
        }).finally(done);
    });

    it("sets lowerBound to 0 and upperBound to 20 when 0 page is selected", () => {
        service.currentPage = 0;
        service.goToSelectedPage();
        expect(service.lowerBound).toBe(0);
        expect(service.upperBound).toBe(20);
    });

    it("sets lowerBound to 20 and upperBound to 40 when 1 page is selected", () => {
        service.currentPage = 1;
        service.goToSelectedPage();
        expect(service.lowerBound).toBe(20);
        expect(service.upperBound).toBe(40);
    });

    it("sets lowerBound to 2000 and upperBound to 2020 when 100 page is selected", () => {
        service.currentPage = 100;
        service.goToSelectedPage();
        expect(service.lowerBound).toBe(2000);
        expect(service.upperBound).toBe(2020);
    });

    it("sets lowerBound to 20 and upperBound to 40 and calls a callback function", () => {
        let mockCallback = jasmine.createSpy("callback");
        service.goToFirstPage(mockCallback);
        expect(mockCallback).toHaveBeenCalled();
        expect(service.lowerBound).toBe(20);
        expect(service.upperBound).toBe(40);
    });

    it("sets lowerBound to 20 and upperBound to 40 without calling a callback function", () => {
        service.goToFirstPage();
        expect(service.lowerBound).toBe(20);
        expect(service.upperBound).toBe(40);
    });

    it("returns 50 with 1000 total items and 20 items to show", () => {
        service.total = 1000;
        expect(service.maxPage()).toBe(50);
    });

    it("returns 1 with 20 total items and 20 items to show", () => {
        service.total = 20;
        expect(service.maxPage()).toBe(1);
    });

    it("returns 1 with 19 total items and 20 items to show", () => {
        service.total = 19;
        expect(service.maxPage()).toBe(1);
    });

    it("returns 2 with 21 total items and 20 items to show", () => {
        service.total = 21;
        expect(service.maxPage()).toBe(2);
    });

    it("returns 0 with 0 total items and 20 items to show", () => {
        service.total = 0;
        expect(service.maxPage()).toBe(0);
    });

    it("sets loweBound to 980 and upperBound to 1000 when 50 page is selected and calls a callback function", () => {
        service.total = 1000;
        let mockCallback = jasmine.createSpy("callback");
        service.goToLastPage(mockCallback);
        expect(mockCallback).toHaveBeenCalled();
        expect(service.lowerBound).toBe(980);
        expect(service.upperBound).toBe(1000);
    });

    it("sets loweBound to 980 and upperBound to 1000 when 50 page is selected without calling a callback function", () => {
        service.total = 1000;
        service.goToLastPage();
        expect(service.lowerBound).toBe(980);
        expect(service.upperBound).toBe(1000);
    });

    it("sets lowerBound to 0 and upperBound to 19 when 1 page is selected and calls a callback function", () => {
        service.total = 19;
        let mockCallback = jasmine.createSpy("callback");
        service.goToLastPage(mockCallback);
        expect(mockCallback).toHaveBeenCalled();
        expect(service.lowerBound).toBe(0);
        expect(service.upperBound).toBe(19);
    });

    it("sets lowerBound to 0 and upperBound to 19 when 1 page is selected without calling a callback function", () => {
        service.total = 19;
        service.goToLastPage();
        expect(service.lowerBound).toBe(0);
        expect(service.upperBound).toBe(19);
    });

    it("sets lowerBound to 20 and upperBound to 21 when 2 page is selected and calls a callback function", () => {
        service.total = 21;
        let mockCallback = jasmine.createSpy("callback");
        service.goToLastPage(mockCallback);
        expect(mockCallback).toHaveBeenCalled();
        expect(service.lowerBound).toBe(20);
        expect(service.upperBound).toBe(21);
    });

    it("sets lowerBound to 20 and upperBound to 21 when 2 page is selected without calling a callback function", () => {
        service.total = 21;
        service.goToLastPage();
        expect(service.lowerBound).toBe(20);
        expect(service.upperBound).toBe(21);
    });
});