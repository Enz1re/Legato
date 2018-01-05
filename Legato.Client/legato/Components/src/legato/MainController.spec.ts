import { MainController } from "./MainController";

import { Price, Sorting } from "../../../Models/models";

import {
    IClaimService,
    IUpdateService,
    IRoutingService,
} from "../../../Interfaces/interfaces";


describe("MainController", () => {
    let mockRoutingService: IRoutingService;
    let mockUpdateService: IUpdateService;
    let mockClaimService: IClaimService;
    let controller: MainController;

    beforeEach(() => {
        mockRoutingService = <IRoutingService>{
            url: "http://localhost:8080",
            urlSegments: ["", "classical"],
            queryParams: null,
            getParamResolver: jasmine.createSpy("getParamResolver"),
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