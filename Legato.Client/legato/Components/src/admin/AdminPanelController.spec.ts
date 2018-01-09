import angular from "angular";

import {
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
    return this.claims.addGuitar && this.claims.editGuitar && this.claims.removeGuitar && this.claims.blockUser;
}


describe("AdminPanelController", () => {
    let $q: ng.IQService;
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

    beforeEach(angular.mock.inject((_$q_: ng.IQService) => {
        $q = _$q_;

        mockUserService = <IUserService>{
            currentUser: null,
            authenticated: false,
            getUsers: jasmine.createSpy("getUsers"),
            blockUser: jasmine.createSpy("blockUser"),
            getCompromisedAttempts: jasmine.createSpy("getCompromisedAttempts").and.callFake(() => {
                let deferred = $q.defer();
                return deferred.promise;
            }),
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
        mockClaimServiceSuperuser = <IClaimService>{
            claims: superUserClaims,
            hasAdminRights: hasAdminRights,
            getUserClaims: jasmine.createSpy("getUserClaims")
        };
        mockModalService = <IModalService>{
            openGuitarModal: jasmine.createSpy("openGuitarModal").and.callFake(() => {
                return {
                    result: $q.defer().promise
                };
            }),
            openLoginModal: jasmine.createSpy("openLoginModal"),
            openGuitarAddOrEditModal: jasmine.createSpy("openGuitarAddOrEditModal").and.callFake(() => {
                return {
                    result: $q.defer().promise
                };
            }),
            openYesNoDialog: jasmine.createSpy("openYesNoDialog"),
            openDisplayAmountModal: jasmine.createSpy("openDisplayAmountModal").and.callFake(() => {
                return {
                    result: $q.defer().promise
                };
            }),
            openAlertModal: jasmine.createSpy("openAlertModal"),
            openUserModal: jasmine.createSpy("openUserModal").and.callFake(() => {
                return {
                    result: $q.defer().promise
                };
            }),
            openCompromisedAttemptsModal: jasmine.createSpy("openCompromisedAttemptsModal").and.callFake(() => {
                return {
                    result: $q.defer().promise
                };
            })
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
    }));

    it("Doesn't load a list of compromised attempts for user", () => {
        controllerUser = new AdminPanelController(mockManageService, mockModalService, mockPagingService, mockUpdateService, mockRoutingService, mockUserService, mockClaimServiceUser);
        expect(mockUserService.getCompromisedAttempts).not.toHaveBeenCalled();
    });

    it("Doesn't load a list of compromised attempts for admin", () => {
        controllerAdmin = new AdminPanelController(mockManageService, mockModalService, mockPagingService, mockUpdateService, mockRoutingService, mockUserService, mockClaimServiceAdmin);
        expect(mockUserService.getCompromisedAttempts).not.toHaveBeenCalled();
    });

    it("Loads a list of compromised attempts for superuser", () => {
        controllerSuperuser = new AdminPanelController(mockManageService, mockModalService, mockPagingService, mockUpdateService, mockRoutingService, mockUserService, mockClaimServiceSuperuser);
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
        controllerAdmin = new AdminPanelController(mockManageService, mockModalService, mockPagingService, mockUpdateService, mockRoutingService, mockUserService, mockClaimServiceAdmin);
        controllerAdmin.addGuitar();
        expect(mockModalService.openGuitarAddOrEditModal).toHaveBeenCalled();
    });

    it("Opens display amount modal", () => {
        controllerSuperuser = new AdminPanelController(mockManageService, mockModalService, mockPagingService, mockUpdateService, mockRoutingService, mockUserService, mockClaimServiceSuperuser);
        controllerSuperuser.changeDisplayAmount();
        expect(mockModalService.openDisplayAmountModal).toHaveBeenCalled();
    });

    it("Opens users modal", () => {
        controllerSuperuser = new AdminPanelController(mockManageService, mockModalService, mockPagingService, mockUpdateService, mockRoutingService, mockUserService, mockClaimServiceSuperuser);
        controllerSuperuser.listUsers();
        expect(mockModalService.openUserModal).toHaveBeenCalled();
    });

    it("Opens compromised attempts modal", () => {
        controllerSuperuser = new AdminPanelController(mockManageService, mockModalService, mockPagingService, mockUpdateService, mockRoutingService, mockUserService, mockClaimServiceSuperuser);
        controllerSuperuser.showCompromisedAttempts();
        expect(mockModalService.openCompromisedAttemptsModal).toHaveBeenCalled();
    });
});