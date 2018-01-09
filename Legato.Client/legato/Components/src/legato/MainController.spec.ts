import angular from "angular";

import { MainController } from "./MainController";

import {
    Price,
    Vendor,
    Sorting
} from "../../../Models/models";

import {
    IClaimService,
    IUpdateService,
    IRoutingService,
    IUrlParamResolver
} from "../../../Interfaces/interfaces";


describe("MainController", () => {
    let mockRoutingService: IRoutingService;
    let paramResolver: IUrlParamResolver;
    let mockUpdateService: IUpdateService;
    let mockClaimService: IClaimService;
    let controller: MainController;

    //beforeEach(() => {
    //    angular.mock.module("legato");
    //});

    beforeEach(() => {
        mockRoutingService = <IRoutingService>{
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
        mockUpdateService = <IUpdateService>{
            filter: {
                price: new Price(),
                vendors: [],
                sorting: new Sorting(),
                search: ""
            },
            updatePage: {
                updateCurrentPage: false,
                updateLastPage: false
            },
            replacePriceQueryParams: jasmine.createSpy("replacePriceQueryParams"),
            replaceVendorQueryParams: jasmine.createSpy("replaceVendorQueryParams"),
            replaceSearchQueryParams: jasmine.createSpy("replaceSearchQueryParams"),
            replaceSortingQueryParams: jasmine.createSpy("replaceSortingQueryParams"),
            needUsePriceFilter: jasmine.createSpy("needUsePriceFilter"),
            needUseVendorFilter: jasmine.createSpy("needUseVendorFilter"),
            needSearch: jasmine.createSpy("needSearch"),
            needUseSorting: jasmine.createSpy("needUseSorting"),
            updateCurrentPage: jasmine.createSpy("updateCurrentPage"),
            updateLastPage: jasmine.createSpy("updateLastPage")
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
        mockClaimService = <IClaimService>{
            claims: userClaims,
            hasAdminRights: function() {
                return this.addGuitar && this.editGuitar && this.removeGuitar && this.blockUser;
            },
            getUserClaims: jasmine.createSpy("getUserClaims")
        };

        controller = new MainController(mockRoutingService, mockUpdateService, mockClaimService);
    });

    it("resolves query params", () => {
        expect(mockRoutingService.getParamResolver).toHaveBeenCalled();
    })
})