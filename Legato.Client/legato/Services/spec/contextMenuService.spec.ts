import ContextMenuService from "../src/ContextMenuService";

import {
    User,
    Guitar,
    UserViewModel,
    CompromisedAttempt
} from "../../Models/models";

import {
    IUserService,
    IModalService,
    IClaimService,
    IManageService,
    IUpdateService,
    IContextMenuService,
    ICompromisedAttemptHelperService
} from "../../Interfaces/interfaces";

let fakeUser: User = {
    username: "User"
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

let fakeAdmin: User = {
    username: "Admin"
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

let fakeSuperuser: User = {
    username: "Superuser"
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


describe("ContextMenuService", () => {
    let contextMenuUser: IContextMenuService;
    let contextMenuAdmin: IContextMenuService;
    let contextMenuSuperuser: IContextMenuService;
    let userServiceUser: IUserService;
    let userServiceAdmin: IUserService;
    let userServiceSuperuser: IUserService;
    let modalService: IModalService;
    let manageService: IManageService;
    let updateService: IUpdateService;
    let compromisedAttemptsService: ICompromisedAttemptHelperService;
    let claimServiceUser: IClaimService;
    let claimServiceAdmin: IClaimService;
    let claimServiceSuperuser: IClaimService;

    beforeEach(() => {
        userServiceUser = <IUserService>{
            currentUser: fakeUser,
            authenticated: true,
            getUsers: jasmine.createSpy("getUsers"),
            blockUser: jasmine.createSpy("blockUser"),
            getCompromisedAttempts: jasmine.createSpy("getCompromisedAttempts"),
            removeCompromisedAttempts: jasmine.createSpy("removeCompromisedAttempts")
        };
        userServiceAdmin = <IUserService>{
            currentUser: fakeAdmin,
            authenticated: true,
            getUsers: jasmine.createSpy("getUsers"),
            blockUser: jasmine.createSpy("blockUser"),
            getCompromisedAttempts: jasmine.createSpy("getCompromisedAttempts"),
            removeCompromisedAttempts: jasmine.createSpy("removeCompromisedAttempts")
        };
        userServiceSuperuser = <IUserService>{
            currentUser: fakeSuperuser,
            authenticated: true,
            getUsers: jasmine.createSpy("getUsers"),
            blockUser: jasmine.createSpy("blockUser"),
            getCompromisedAttempts: jasmine.createSpy("getCompromisedAttempts"),
            removeCompromisedAttempts: jasmine.createSpy("removeCompromisedAttempts")
        };
        manageService = <IManageService>{
            addGuitar: jasmine.createSpy("addGuitar"),
            removeGuitar: jasmine.createSpy("removeGuitar"),
            editGuitarCharacteristics: jasmine.createSpy("editGuitarCharacteristics"),
            getDisplayAmount: jasmine.createSpy("getDisplayAmount"),
            changeDisplayAmount: jasmine.createSpy("changeDisplayAmount")
        };
        modalService = <IModalService>{
            openGuitarModal: jasmine.createSpy("openGuitarModal"),
            openLoginModal: jasmine.createSpy("openLoginModal"),
            openGuitarAddOrEditModal: jasmine.createSpy("openGuitarAddOrEditModal"),
            openYesNoDialog: jasmine.createSpy("openYesNoDialog"),
            openDisplayAmountModal: jasmine.createSpy("openDisplayAmountModal"),
            openAlertModal: jasmine.createSpy("openAlertModal"),
            openUserModal: jasmine.createSpy("openUserModal"),
            openCompromisedAttemptsModal: jasmine.createSpy("openCompromisedAttemptsModal")
        };
        updateService = <IUpdateService>{
            filter: { price: null, vendors: [], sorting: null, search: "" },
            updatePage: { updateCurrentPage: false, updateLastPage: false },
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
        compromisedAttemptsService = <ICompromisedAttemptHelperService>{
            changed: false,
            allCompromisedAttempts: [],
            checkedCompromisedAttempts: [],
            addAttemptToCheckList: jasmine.createSpy("addAttemptToCheckList"),
            removeAttemptFromCheckList: jasmine.createSpy("removeAttemptFromCheckList"),
            removeAttempt: jasmine.createSpy("removeAttempt"),
            selectAll: jasmine.createSpy("selectAll"),
            deselectAll: jasmine.createSpy("deselectAll"),
            clear: jasmine.createSpy("clear"),
        };
        claimServiceUser = <IClaimService>{
            claims: userClaims,
            hasAdminRights: jasmine.createSpy("hasAdminRights"),
            getUserClaims: jasmine.createSpy("getUserClaims")
        };
        claimServiceAdmin = <IClaimService>{
            claims: adminClaims,
            hasAdminRights: jasmine.createSpy("hasAdminRights"),
            getUserClaims: jasmine.createSpy("getUserClaims")
        };
        claimServiceSuperuser = <IClaimService>{
            claims: superUserClaims,
            hasAdminRights: jasmine.createSpy("hasAdminRights"),
            getUserClaims: jasmine.createSpy("getUserClaims")
        };

        contextMenuUser = new ContextMenuService(manageService, modalService, updateService, userServiceUser, compromisedAttemptsService, claimServiceUser);
        contextMenuAdmin = new ContextMenuService(manageService, modalService, updateService, userServiceAdmin, compromisedAttemptsService, claimServiceAdmin);
        contextMenuSuperuser = new ContextMenuService(manageService, modalService, updateService, userServiceSuperuser, compromisedAttemptsService, claimServiceSuperuser);
    });

    it("doesn't display 'Remove' option in guitar options for user", () => {
        expect(contextMenuUser.guitarOptions[0].displayed()).toBe(false);
    });

    it("displays 'Remove' option in guitar options for admin", () => {
        expect(contextMenuAdmin.guitarOptions[0].displayed()).toBe(true);
    });

    it("displays 'Remove' option in guitar options for superuser", () => {
        expect(contextMenuSuperuser.guitarOptions[0].displayed()).toBe(true);
    });

    it("doesn't display 'Edit' option in guitar options for user", () => {
        expect(contextMenuUser.guitarOptions[1].displayed()).toBe(false);
    });

    it("displays 'Edit' option in guitar options for admin", () => {
        expect(contextMenuAdmin.guitarOptions[1].displayed()).toBe(true);
    });

    it("displays 'Edit' option in guitar options for superuser", () => {
        expect(contextMenuSuperuser.guitarOptions[1].displayed()).toBe(true);
    });

    it("doesn't display 'Block' option in guitar options for user", () => {
        expect(contextMenuUser.userOptions[0].displayed()).toBe(false);
    });

    it("displays 'Block' option in guitar options for admin", () => {
        expect(contextMenuAdmin.userOptions[0].displayed()).toBe(true);
    });

    it("displays 'Block' option in guitar options for superuser", () => {
        expect(contextMenuSuperuser.userOptions[0].displayed()).toBe(true);
    });

    it("doesn't display 'Delete' option in attempt options for user", () => {
        expect(contextMenuUser.attemptOptions[0].displayed()).toBe(false);
    });

    it("doesn't display 'Delete' option in attempt options for admin while attempt list is empty", () => {
        expect(contextMenuAdmin.attemptOptions[0].displayed()).toBe(false);
    });

    it("doesn't display 'Delete' option in attempt options for superuser while attempt list is empty", () => {
        expect(contextMenuSuperuser.attemptOptions[0].displayed()).toBe(false);
    });

    it("doesn't display 'Delete' option in attempt options for admin with one element in attempt list", () => {
        compromisedAttemptsService.checkedCompromisedAttempts.push({ attemptId: 0, compromisedToken: "2FEBC94679A24C50941186F2BE0293C1", requestIP: "::1", username: "User1", requestDateTime: new Date(), isSelected: false });
        expect(contextMenuAdmin.attemptOptions[0].displayed()).toBe(false);
    });

    it("doesn't display 'Delete' option in attempt options for admin when more than one element in attempt list", () => {
        compromisedAttemptsService.checkedCompromisedAttempts.push({ attemptId: 0, compromisedToken: "2FEBC94679A24C50941186F2BE0293C1", requestIP: "::1", username: "User1", requestDateTime: new Date(), isSelected: false });
        compromisedAttemptsService.checkedCompromisedAttempts.push({ attemptId: 1, compromisedToken: "D254BE2B1A2B4BC389F88F1D1F37BF6C", requestIP: "::1", username: "User2", requestDateTime: new Date(), isSelected: false });
        expect(contextMenuAdmin.attemptOptions[0].displayed()).toBe(false);
    });

    it("doesn't display 'Delete checked' option in attempt options for admin when more than one element in attempt list", () => {
        compromisedAttemptsService.checkedCompromisedAttempts.push({ attemptId: 0, compromisedToken: "2FEBC94679A24C50941186F2BE0293C1", requestIP: "::1", username: "User1", requestDateTime: new Date(), isSelected: false });
        compromisedAttemptsService.checkedCompromisedAttempts.push({ attemptId: 1, compromisedToken: "D254BE2B1A2B4BC389F88F1D1F37BF6C", requestIP: "::1", username: "User2", requestDateTime: new Date(), isSelected: false });
        expect(contextMenuAdmin.attemptOptions[1].displayed()).toBe(false);
    });

    it("doesn't display 'Delete checked' option in attempt options for admin with one element in attempt list", () => {
        compromisedAttemptsService.checkedCompromisedAttempts.push({ attemptId: 0, compromisedToken: "2FEBC94679A24C50941186F2BE0293C1", requestIP: "::1", username: "User1", requestDateTime: new Date(), isSelected: false });
        expect(contextMenuAdmin.attemptOptions[1].displayed()).toBe(false);
    });

    it("displays 'Delete' option in attempt options for superuser with one element in attempt list", () => {
        compromisedAttemptsService.checkedCompromisedAttempts.push({ attemptId: 0, compromisedToken: "2FEBC94679A24C50941186F2BE0293C1", requestIP: "::1", username: "User1", requestDateTime: new Date(), isSelected: false });
        expect(contextMenuSuperuser.attemptOptions[0].displayed()).toBe(true);
    });

    it("doesn't display 'Delete' option in attempt options for superuser when more than one element in attempt list", () => {
        compromisedAttemptsService.checkedCompromisedAttempts.push({ attemptId: 0, compromisedToken: "2FEBC94679A24C50941186F2BE0293C1", requestIP: "::1", username: "User1", requestDateTime: new Date(), isSelected: false });
        compromisedAttemptsService.checkedCompromisedAttempts.push({ attemptId: 1, compromisedToken: "D254BE2B1A2B4BC389F88F1D1F37BF6C", requestIP: "::1", username: "User2", requestDateTime: new Date(), isSelected: false });
        expect(contextMenuSuperuser.attemptOptions[0].displayed()).toBe(false);
    });

    it("displays 'Delete checked' option in attempt options for superuser when more than one element in attempt list", () => {
        compromisedAttemptsService.checkedCompromisedAttempts.push({ attemptId: 0, compromisedToken: "2FEBC94679A24C50941186F2BE0293C1", requestIP: "::1", username: "User1", requestDateTime: new Date(), isSelected: false });
        compromisedAttemptsService.checkedCompromisedAttempts.push({ attemptId: 1, compromisedToken: "D254BE2B1A2B4BC389F88F1D1F37BF6C", requestIP: "::1", username: "User2", requestDateTime: new Date(), isSelected: false });
        expect(contextMenuSuperuser.attemptOptions[1].displayed()).toBe(true);
    });

    it("doesn't display 'Delete checked' option in attempt options for superuser with one element in attempt list", () => {
        compromisedAttemptsService.checkedCompromisedAttempts.push({ attemptId: 0, compromisedToken: "2FEBC94679A24C50941186F2BE0293C1", requestIP: "::1", username: "User1", requestDateTime: new Date(), isSelected: false });
        expect(contextMenuSuperuser.attemptOptions[1].displayed()).toBe(false);
    });
});