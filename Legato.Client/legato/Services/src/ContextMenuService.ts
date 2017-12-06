import { Guitar } from "../../Models/models";

import {
    IModalService,
    IManageService,
    IContextMenuService,
} from "../../Interfaces/interfaces";


export default class ContextMenuService implements IContextMenuService {
    static $inject = ["ManageService", "ModalService"];
    menuOptions = [
        {
            text: "Remove",
            click: ($itemScope, $event, modelValue: Guitar, text, $li, data) => {
                console.log(data);
                this.modalService.openGuitarDeleteDialog({ guitar: modelValue }).result.then(() => {
                    this.manageService.removeGuitar(modelValue).then(val => console.log(val));
                }).catch(() => { });
            }
        },
        {
            text: "Edit",
            click: ($itemScope, $event, modelValue: Guitar, text, $li, data) => {
                this.modalService.openGuitarAddOrEditModal({
                    guitar: modelValue,
                    type: () => data.type
                }).result.then(edited => {
                    this.manageService.editGuitarCharacteristics(edited).then(val => console.log(val));
                }).catch(() => { });
            }
        }
    ];

    constructor(private manageService: IManageService, private modalService: IModalService) {

    }
}