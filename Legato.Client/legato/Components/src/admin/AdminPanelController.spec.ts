﻿import {
    Price,
    Vendor,
    Sorting,
    LegatoClaims
} from "../../../Models/models";

import { AdminPanelController } from "./AdminPanelController";

import {
    IUserService,
    IClaimService,
    IModalService,
    IManageService,
    IPagingService,
    IUpdateService,
    IRoutingService,
} from "../../../Interfaces/interfaces";


function hasAdminRights() {
    return this.addGuitar && this.editGuitar && this.removeGuitar && this.blockUser;
}


describe("AdminPanelController", () => {
    let controllerUser: AdminPanelController;
    let controllerAdmin: AdminPanelController;
    let controllerSuperuser: AdminPanelController;
    let mockUserService: IUserService;
    let mockClaimServiceUser: IClaimService;
    let mockClaimServiceAdmin: IClaimService;
    let mockClaimServiceSuperuser: IClaimService;
    let mockModalService: IModalService;
    let mockManageService: IManageService;
    let mockPagingService: IPagingService;
    let mockUpdateService: IUpdateService;
    let mockRoutingService: IRoutingService;

    beforeEach(() => {
        mockUserService = <IUserService>{
            currentUser: null,
            authenticated: false,
            getUsers: jasmine.createSpy("getUsers"),
            blockUser: jasmine.createSpy("blockUser"),
            getCompromisedAttempts: jasmine.createSpy("getCompromisedAttempts"),
            removeCompromisedAttempts: jasmine.createSpy("removeCompromisedAttempts")
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
        mockClaimServiceUser = <IClaimService>{
            claims: userClaims,
            hasAdminRights: hasAdminRights,
            getUserClaims: jasmine.createSpy("getUserClaims")
        };
        const adminClaims = {
            addGuitar: true,
            changeDisplayAmount: false,
            getListOfUsers: false,
            blockUser: true,
            removeGuitar: true,
            editGuitar: true,
            getCompromisedAttempts: false,
            removeCompromiseAttempts: false
        };
        mockClaimServiceAdmin = <IClaimService>{
            claims: adminClaims,
            hasAdminRights: hasAdminRights,
            getUserClaims: jasmine.createSpy("getUserClaims")
        };
        const superUserClaims = {
            addGuitar: true,
            changeDisplayAmount: true,
            getListOfUsers: true,
            blockUser: true,
            removeGuitar: true,
            editGuitar: true,
            getCompromisedAttempts: true,
            removeCompromiseAttempts: true
        };
        mockClaimServiceUser = <IClaimService>{
            claims: superUserClaims,
            hasAdminRights: hasAdminRights,
            getUserClaims: jasmine.createSpy("getUserClaims")
        };
        mockModalService = <IModalService>{
            openGuitarModal: jasmine.createSpy("openGuitarModal"),
            openLoginModal: jasmine.createSpy("openLoginModal"),
            openGuitarAddOrEditModal: jasmine.createSpy("openGuitarAddOrEditModal"),
            openYesNoDialog: jasmine.createSpy("openYesNoDialog"),
            openDisplayAmountModal: jasmine.createSpy("openDisplayAmountModal"),
            openAlertModal: jasmine.createSpy("openAlertModal"),
            openUserModal: jasmine.createSpy("openUserModal"),
            openCompromisedAttemptsModal: jasmine.createSpy("openCompromisedAttemptsModal")
        };
        mockManageService = <IManageService>{
            addGuitar: jasmine.createSpy("addGuitar"),
            removeGuitar: jasmine.createSpy("removeGuitar"),
            editGuitarCharacteristics: jasmine.createSpy("editGuitarCharacteristics"),
            getDisplayAmount: jasmine.createSpy("getDisplayAmount"),
            changeDisplayAmount: jasmine.createSpy("changeDisplayAmount")
        };
        mockPagingService = <IPagingService>{
            total: 1000,
            lowerBound: 0,
            upperBound: 20,
            currentPage: 1,
            itemsToShow: 20,
            goToSelectedPage: jasmine.createSpy("goToSelectedPage"),
            goToLastPage: jasmine.createSpy("goToLastPage"),
            goToFirstPage: jasmine.createSpy("goToFirstPage"),
            maxPage: jasmine.createSpy("maxPage")
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
        mockRoutingService = <IRoutingService>{
            url: "http://localhost:8080",
            urlSegments: ["", "classical"],
            queryParams: null,
            getParamResolver: jasmine.createSpy("getParamResolver"),
            redirect: jasmine.createSpy("redirect"),
            replace: jasmine.createSpy("replace")
        };

        controllerUser = new AdminPanelController(mockManageService, mockModalService, mockPagingService, mockUpdateService, mockRoutingService, mockUserService, mockClaimServiceUser);
        controllerAdmin = new AdminPanelController(mockManageService, mockModalService, mockPagingService, mockUpdateService, mockRoutingService, mockUserService, mockClaimServiceAdmin);
        controllerSuperuser = new AdminPanelController(mockManageService, mockModalService, mockPagingService, mockUpdateService, mockRoutingService, mockUserService, mockClaimServiceSuperuser);
    });

    it("Doesn't load a list of compromised attempts for user", () => {
        expect(mockUserService.getCompromisedAttempts).not.toHaveBeenCalled();
    });

    it("Doesn't load a list of compromised attempts for admin", () => {
        expect(mockUserService.getCompromisedAttempts).not.toHaveBeenCalled();
    });

    it("Loads a list of compromised attempts for superuser", () => {
        expect(mockUserService.getCompromisedAttempts).toHaveBeenCalled();
    });

    it("Doesn't grant admin rights for user", () => {
        expect(mockClaimServiceUser.hasAdminRights()).toBe(false);
    });

    it("Grants admin rights for admin", () => {
        expect(mockClaimServiceAdmin.hasAdminRights()).toBe(true);
    });

    it("Grants admin rights for superuser", () => {
        expect(mockClaimServiceSuperuser.hasAdminRights()).toBe(true);
    });

    it("Opens add guitar modal", () => {
        controllerAdmin.addGuitar();
        expect(mockModalService.openGuitarAddOrEditModal).toHaveBeenCalled();
    });

    it("Opens display amount modal", () => {
        controllerSuperuser.changeDisplayAmount();
        expect(mockModalService.openDisplayAmountModal).toHaveBeenCalled();
    });

    it("Opens users modal", () => {
        controllerSuperuser.listUsers();
        expect(mockModalService.openUserModal).toHaveBeenCalled();
    });

    it("Opens compromised attempts modal", () => {
        controllerSuperuser.showCompromisedAttempts();
        expect(mockModalService.openCompromisedAttemptsModal).toHaveBeenCalled();
    });
});