import {
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


export default class ContextMenuService implements IContextMenuService {
    static $inject = ["ManageService", "ModalService", "UpdateService", "UserService", "CompromisedAttemptHelperService", "ClaimService"];
    guitarOptions = [
        {
            text: "Remove",
            displayed: () => this.claimService.claims.removeGuitar,
            click: ($itemScope, $event, modelValue: Guitar, text, $li, data) => {
                this.modalService.openYesNoDialog(`Are you sure you want to delete guitar ${modelValue.vendor.name} ${modelValue.model} with product id ${modelValue.id}?`).result.then(() => {
                    this.manageService.removeGuitar(modelValue, data.type).then(val => {
                        this.updateService.updateCurrentPage();
                    }).catch(err => {
                        this.modalService.openAlertModal(`Failed to remove guitar ${modelValue.vendor.name} ${modelValue.model}. ${err.statusText}`, "danger");
                    });
                }).catch(() => {});
            }
        },
        {
            text: "Edit",
            displayed: () => this.claimService.claims.editGuitar,
            click: ($itemScope, $event, modelValue: Guitar, text, $li, data) => {
                this.modalService.openGuitarAddOrEditModal({
                    guitar: { ...modelValue, vendor: { ...modelValue.vendor } },
                    type: () => data.type
                }).result.then(edited => {
                    this.manageService.editGuitarCharacteristics(edited.guitar, data.type).then(() => {
                        this.updateService.updateCurrentPage();
                    }).catch(err => {
                        this.modalService.openAlertModal(`Failed to save changes: ${modelValue.vendor.name} ${modelValue.model}. ${err.data.message}`, "danger").result.catch(() => { });
                    });
                }).catch(() => { });
            }
        }
    ];

    userOptions = [
        {
            text: "Block",
            displayed: () => this.claimService.claims.blockUser,
            click: ($itemScope, $event, modelValue: UserViewModel, text, $li, data) => {
                this.modalService.openYesNoDialog(`Are you sure you want to block user ${modelValue.name}? This action is irreversible.`).result.then(() => {
                    this.userService.blockUser(modelValue.name).then(() => {
                        modelValue.isAuthenticated = false;
                    }).catch(err => {
                        this.modalService.openAlertModal(err.data.message, "danger").result.catch(() => { });
                    });
                }).catch(() => { });
            }
        }
    ];

    attemptOptions = [
        {
            text: "Delete",
            displayed: () => this.claimService.claims.removeCompromiseAttempts && this.attemptService.checkedCompromisedAttempts.length === 1,
            click: ($itemScope, $event, modelValue: CompromisedAttempt, text, $li, data) => {
                this.modalService.openYesNoDialog(`Detele attempt '${modelValue.requestDateTime}'? This action is irreversible`).result.then(() => {
                    this.userService.removeCompromisedAttempts([modelValue.attemptId]).then(() => {
                        this.attemptService.removeAttempt(modelValue);
                    }).catch(err => {
                        this.modalService.openAlertModal(err.data.message, "danger").result.catch(() => { });
                    });
                }).catch(() => { });
            }
        },
        {
            text: "Delete checked",
            displayed: () => this.claimService.claims.removeCompromiseAttempts && this.attemptService.checkedCompromisedAttempts.length > 1,
            click: ($itemScope, $event, modelValue: CompromisedAttempt, text, $li, data) => {
                this.modalService.openYesNoDialog("Do you want to delete checked attempts? This action is irreversible").result.then(() => {
                    var attempts = this.attemptService.checkedCompromisedAttempts;
                    this.userService.removeCompromisedAttempts(attempts.map(attempt => attempt.attemptId)).then(() => {
                        for (let i = attempts.length - 1; i >= 0; i--) {
                            this.attemptService.removeAttempt(attempts[i]);
                        }
                    }).catch(err => {
                        this.modalService.openAlertModal(err.data.message, "danger").result.catch(() => { });
                    });
                }).catch(() => { });
            }
        }
    ];

    constructor(private manageService: IManageService, private modalService: IModalService, private updateService: IUpdateService,
                private userService: IUserService, private attemptService: ICompromisedAttemptHelperService, private claimService: IClaimService) {

    }
}