import { Guitar } from "../../../Models/models";

import {
    IModalService,
    IManageService,
    IPagingService,
    IUpdateService
} from "../../../Interfaces/interfaces";


export class AdminPanelController {
    static $inject = ["ManageService", "ModalService", "PagingService", "UpdateService"];

    constructor(private manageService: IManageService, private modalService: IModalService, private pagingService: IPagingService, private updateService: IUpdateService) {

    }

    addGuitar() {
        this.modalService.openGuitarAddOrEditModal({
            guitar: null,
            type: null
        }).result.then(resp => {
            this.manageService.editGuitarCharacteristics(resp.guitar, resp.type).then(() => {
                this.updateService.updateData();
            }).catch(() => {
                this.modalService.openAlertModal("Failed to add new guitar", "danger");
            });
        }).catch(() => { });
    }

    changeDisplayAmount() {
        this.modalService.openDisplayAmountModal({ amount: this.pagingService.itemsToShow }).result.then((amount: number) => {
            this.pagingService.itemsToShow = amount;
            this.updateService.updateData();
        }).catch(() => {
            this.modalService.openAlertModal("Failed to change display amount", "danger");
        })
    }
}