import { Guitar } from "../../../Models/models";

import { IManageService, IModalService } from "../../../Interfaces/interfaces";


export class AdminPanelController {
    static $inject = ["ManageService", "ModalService"];

    constructor(private manageService: IManageService, private modalService: IModalService) {

    }

    addGuitar() {
        this.modalService.openGuitarAddOrEditModal().result.then((guitar: Guitar) => {
            console.log(guitar);
        });
    }

    changeDisplayAmount() {
        this.modalService.openDisplayAmountModal().result.then((amount: number) => {
            console.log(amount);
        })
    }
}