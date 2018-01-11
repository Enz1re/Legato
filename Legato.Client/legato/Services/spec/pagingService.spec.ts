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
            getDisplayAmount: jasmine.createSpy("getDisplayAmount").and.callFake(() => {
                return _$q_.resolve(displayAmount);
            }),
            changeDisplayAmount: jasmine.createSpy("changeDisplayAmount")
        };
        routingService = <IRoutingService>{
            url: "http://localhost:8080",
            urlSegments: ["", "classical"],
            queryParams: null,
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

    it("gets display amount on service initialization", () => {
        expect(service.init).toHaveBeenCalled();
        expect(manageService.changeDisplayAmount).toHaveBeenCalled();
    });

    it("initializes itemsToShow, lowerBound and upperBound with default values", done => {
        service.init().then(() => {
            expect(service.itemsToShow).toBe(displayAmount);
            expect(service.lowerBound).toBe(0);
            expect(service.upperBound).toBe(displayAmount);
            done();
        }).catch(err => {
            fail(err);
        }).finally(done);
    });


});