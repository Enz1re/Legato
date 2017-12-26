import {
    Guitar,
    UserViewModel,
    CompromisedAttempt
} from "../../Models/models";

import {
    IUserService,
    IModalService,
    IManageService,
    IUpdateService,
    IContextMenuService,
    ICompromisedAttemptHelperService
} from "../../Interfaces/interfaces";


export default class ContextMenuService implements IContextMenuService {
    static $inject = ["ManageService", "ModalService", "UpdateService", "UserService", "CompromisedAttemptHelperService"];
    guitarOptions = [
        {
            text: "Remove",
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
            click: ($itemScope, $event, modelValue: UserViewModel, text, $li, data) => {
                this.modalService.openYesNoDialog(`Are you sure you want to block user ${modelValue.name}? This action is irreversible.`).result.then(() => {
                    this.userService.blockUser(modelValue.name).then(() => {
                        modelValue.isAuthenticated = false;
                    }).catch(err => {
                        this.modalService.openAlertModal(err.data.exceptionMessage, "danger").result.catch(() => { });
                    });
                }).catch(() => { });
            }
        }
    ];

    attemptOptions = [
        {
            text: "Delete",
            displayed: () => this.attemptService.getAttempts().length === 1,
            click: ($itemScope, $event, modelValue: CompromisedAttempt, text, $li, data: CompromisedAttempt[]) => {
                this.modalService.openYesNoDialog(`Detele attempt '${modelValue.requestDateTime}'? This action is irreversible`).result.then(() => {
                    this.userService.removeCompromisedAttempts([modelValue.attemptId]).then(() => {
                        data.splice(data.indexOf(modelValue), 1);
                    }).catch(err => {
                        this.modalService.openAlertModal(err.data.exceptionMessage, "danger").result.catch(() => { });
                    });
                }).catch(() => { });
            }
        },
        {
            text: "Delete checked",
            displayed: () => this.attemptService.getAttempts().length > 0,
            click: ($itemScope, $event, modelValue: CompromisedAttempt, text, $li, data: CompromisedAttempt[]) => {
                this.modalService.openYesNoDialog("Do you want to delete checked attempts? This action is irreversible").result.then(() => {
                    var attempts = this.attemptService.getAttempts();
                    this.userService.removeCompromisedAttempts(attempts.map(attempt => attempt.attemptId)).then(() => {
                        for (let i = attempts.length - 1; i >= 0; i--) {
                            data.splice(data.indexOf(attempts[i]), 1);
                        }
                    }).catch(err => {
                        this.modalService.openAlertModal(err.data.exceptionMessage, "danger").result.catch(() => { });
                    });
                }).catch(() => { });
            }
        }
    ];

    constructor(private manageService: IManageService, private modalService: IModalService, private updateService: IUpdateService,
                private userService: IUserService, private attemptService: ICompromisedAttemptHelperService) {

    }
}