import { Guitar } from "../../Models/models";

import {
    IModalService,
    IManageService,
    IUpdateService,
    IContextMenuService,
} from "../../Interfaces/interfaces";


export default class ContextMenuService implements IContextMenuService {
    static $inject = ["ManageService", "ModalService", "UpdateService"];
    menuOptions = [
        {
            text: "Remove",
            click: ($itemScope, $event, modelValue: Guitar, text, $li, data) => {
                this.modalService.openGuitarDeleteDialog({ guitar: modelValue }).result.then(() => {
                    this.manageService.removeGuitar(modelValue, data.type).then(val => {
                        this.updateService.updateData();
                    }).catch(err => {
                        this.modalService.openAlertModal(`Failed to remove guitar ${modelValue.vendor.name} ${modelValue.model}. ${err.message}`, "danger");
                    });
                }).catch(() => {});
            }
        },
        {
            text: "Edit",
            click: ($itemScope, $event, modelValue: Guitar, text, $li, data) => {
                this.modalService.openGuitarAddOrEditModal({
                    guitar: modelValue,
                    type: () => data.type
                }).result.then(edited => {
                    this.manageService.editGuitarCharacteristics(edited, data.type).then(() => {
                        this.updateService.updateData();
                    }).catch(() => { });
                }).catch(err => {
                    this.modalService.openAlertModal(`Failed to save changes: ${modelValue.vendor.name} ${modelValue.model}. ${err.message}`, "danger");
                });
            }
        }
    ];

    constructor(private manageService: IManageService, private modalService: IModalService, private updateService: IUpdateService) {

    }
}