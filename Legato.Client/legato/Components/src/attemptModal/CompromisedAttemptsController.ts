import { CompromisedAttempt } from "../../../Models/models";

import {
    IUserService,
    IModalService,
    IContextMenuService,
    ICompromisedAttemptHelperService
} from "../../../Interfaces/interfaces";


export class CompromisedAttemptsController {
    static $inject = ["$uibModalInstance", "ContextMenuService", "UserService", "CompromisedAttemptHelperService", "ModalService", "compromisedAttempts"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, private contextMenu: IContextMenuService, private userService: IUserService,
                private attemptService: ICompromisedAttemptHelperService, private modalService: IModalService, compromisedAttempts: CompromisedAttempt[]) {
        this.attemptService.allCompromisedAttempts = compromisedAttempts;
    }

    removeAttempt(e, attempt: CompromisedAttempt) {
        e.stopPropagation();
        this.modalService.openYesNoDialog(`Detele attempt '${attempt.requestDateTime}'? This action is irreversible`).result.then(() => {
            this.userService.removeCompromisedAttempts([attempt.attemptId]).then(() => {
                this.attemptService.removeAttempt(attempt);
                if (this.attemptService.allCompromisedAttempts.length === 0) {
                    this.onOkButtonClicked();
                }
            }).catch(err => {
                this.modalService.openAlertModal(err.data.message, "danger").result.catch(() => { });
            });
        }).catch(() => { });
    }

    checkOrUncheckRow(e: Event, model: CompromisedAttempt) {
        e.stopPropagation();
        model.isSelected = !model.isSelected;
        this.checkOrUncheckAttempt(e, model);
    }

    checkOrUncheckAttempt(e: Event, model: CompromisedAttempt) {
        e.stopPropagation();
        if (model.isSelected) {
            this.attemptService.addAttemptToCheckList(model);
        } else {
            this.attemptService.removeAttemptFromCheckList(model);
        }
    }

    selectAll() {
        this.attemptService.selectAll();
    }

    deselectAll() {
        this.attemptService.deselectAll();
    }

    onOkButtonClicked() {
        this.attemptService.clear();
        this.$uibModalInstance.close(this.attemptService.pristine);
    }
}