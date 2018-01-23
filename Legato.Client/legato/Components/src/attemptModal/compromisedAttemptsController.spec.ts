import { CompromisedAttemptsController } from "./CompromisedAttemptsController";

import { CompromisedAttempt } from "../../../Models/models";

import {
    IUserService,
    IModalService,
    IContextMenuService,
    ICompromisedAttemptHelperService
} from "../../../Interfaces/interfaces";

const compromisedAttempts: CompromisedAttempt[] = [
    { attemptId: 0, compromisedToken: "DE0D39D1B835435DA15F8AEB1C3F4492", requestIP: "::1", requestDateTime: new Date(), username: "User", isSelected: false },
    { attemptId: 1, compromisedToken: "DE0D39D1B835435DA15F8AEB1C3F4492", requestIP: "::1", requestDateTime: new Date(), username: "User", isSelected: false },
    { attemptId: 2, compromisedToken: "DE0D39D1B835435DA15F8AEB1C3F4492", requestIP: "::1", requestDateTime: new Date(), username: "User", isSelected: false },
    { attemptId: 3, compromisedToken: "DE0D39D1B835435DA15F8AEB1C3F4492", requestIP: "::1", requestDateTime: new Date(), username: "User", isSelected: false },
    { attemptId: 4, compromisedToken: "DE0D39D1B835435DA15F8AEB1C3F4492", requestIP: "::1", requestDateTime: new Date(), username: "User", isSelected: false },
    { attemptId: 5, compromisedToken: "DE0D39D1B835435DA15F8AEB1C3F4492", requestIP: "::1", requestDateTime: new Date(), username: "User", isSelected: false },
    { attemptId: 6, compromisedToken: "DE0D39D1B835435DA15F8AEB1C3F4492", requestIP: "::1", requestDateTime: new Date(), username: "User", isSelected: false },
    { attemptId: 7, compromisedToken: "DE0D39D1B835435DA15F8AEB1C3F4492", requestIP: "::1", requestDateTime: new Date(), username: "User", isSelected: false },
    { attemptId: 8, compromisedToken: "DE0D39D1B835435DA15F8AEB1C3F4492", requestIP: "::1", requestDateTime: new Date(), username: "User", isSelected: false }
];

const event = <Event>{ stopPropagation: () => { } };


describe("CompromisedAttemptsController", () => {
    let $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance;
    let contextMenu: IContextMenuService;
    let userService: IUserService;
    let attemptService: ICompromisedAttemptHelperService;
    let modalService: IModalService;
    let controller: CompromisedAttemptsController;

    beforeEach(inject((_$q_: ng.IQService) => {
        $uibModalInstance = <ng.ui.bootstrap.IModalServiceInstance>{
            close: jasmine.createSpy("close"),
            dismiss: jasmine.createSpy("dismiss"),
            result: _$q_.when(),
            opened: _$q_.when(),
            rendered: _$q_.when(),
            closed: _$q_.when()
        };
        contextMenu = <IContextMenuService>{};
        userService = <IUserService>{
            currentUser: { username: "Superuser" },
            authenticated: true,
            getUsers: jasmine.createSpy("getUsers"),
            blockUser: jasmine.createSpy("blockUser"),
            getCompromisedAttempts: jasmine.createSpy("getCompromisedAttempts"),
            removeCompromisedAttempts: jasmine.createSpy("removeCompromisedAttempts")
        };
        attemptService = <ICompromisedAttemptHelperService>{
            changed: false,
            allCompromisedAttempts: compromisedAttempts,
            checkedCompromisedAttempts: [],
            addAttemptToCheckList: jasmine.createSpy("addAttemptToCheckList"),
            removeAttemptFromCheckList: jasmine.createSpy("removeAttemptFromCheckList"),
            removeAttempt: jasmine.createSpy("removeAttempt"),
            selectAll: jasmine.createSpy("selectAll"),
            deselectAll: jasmine.createSpy("deselectAll"),
            clear: jasmine.createSpy("clear")
        };
        modalService = <IModalService>{
            openGuitarModal: jasmine.createSpy("openGuitarModal").and.returnValue({ result: _$q_.defer().promise }),
            openLoginModal: jasmine.createSpy("openLoginModal"),
            openGuitarAddOrEditModal: jasmine.createSpy("openGuitarAddOrEditModal").and.returnValue({ result: _$q_.defer().promise }),
            openYesNoDialog: jasmine.createSpy("openYesNoDialog"),
            openDisplayAmountModal: jasmine.createSpy("openDisplayAmountModal").and.returnValue({ result: _$q_.defer().promise }),
            openAlertModal: jasmine.createSpy("openAlertModal"),
            openUserModal: jasmine.createSpy("openUserModal").and.returnValue({ result: _$q_.defer().promise }),
            openCompromisedAttemptsModal: jasmine.createSpy("openCompromisedAttemptsModal").and.returnValue({ result: _$q_.defer().promise }),
        };

        controller = new CompromisedAttemptsController($uibModalInstance, contextMenu, userService, attemptService, modalService, [...compromisedAttempts]);
    }));

    it("removes selected attempt from list", done => {
        controller.removeAttempt(event, compromisedAttempts[5]).then(() => {
            expect(attemptService.allCompromisedAttempts.length).toBe(8);
            expect(attemptService.allCompromisedAttempts[4]).toBe(compromisedAttempts[4]);
            expect(attemptService.allCompromisedAttempts[5]).toBe(compromisedAttempts[6]);
        }).catch(err => {
            fail(err);
        }).finally(done);
    });

    it("doesn't remove attempt which is not present in the list", done => {
        controller.removeAttempt(event, {
            attemptId: 9,
            compromisedToken: "DE0D39D1B835435DA15F8AEB1C3F4492",
            requestIP: "192.168.0.1",
            requestDateTime: new Date(),
            username: "User",
            isSelected: false
        }).then(() => {
            expect(attemptService.allCompromisedAttempts.length).toBe(9);
        }).catch(err => {
            fail(err);
        }).finally(done);
    });

    it("turns isSelected from false to true and adds attempt to selected list", () => {
        const attempt: CompromisedAttempt = { attemptId: 0, compromisedToken: "1ABE3FF09FD64CF4A72518D51F91222C", requestIP: "::1", requestDateTime: new Date(), username: "User", isSelected: false };
        controller.checkOrUncheckRow(event, attempt);
        expect(attempt.isSelected);
        expect(attemptService.checkedCompromisedAttempts.length).toBe(1);
    });

    it("turns isSelected from true to false and removes it from selected list", () => {
        const attempt: CompromisedAttempt = { attemptId: 0, compromisedToken: "1ABE3FF09FD64CF4A72518D51F91222C", requestIP: "::1", requestDateTime: new Date(), username: "User", isSelected: false };
        controller.checkOrUncheckRow(event, attempt);
        controller.checkOrUncheckRow(event, attempt);
        expect(attempt.isSelected).toBe(false);
        expect(attemptService.checkedCompromisedAttempts.length).toBe(0);
    });
});