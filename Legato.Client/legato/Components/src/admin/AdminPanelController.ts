import { Guitar } from "../../../Models/models";

import {
    IModalService,
    IManageService,
    IPagingService,
} from "../../../Interfaces/interfaces";


export class AdminPanelController {
    static $inject = ["ManageService", "ModalService", "PagingService"];

    constructor(private manageService: IManageService, private modalService: IModalService, private pagingService: IPagingService) {

    }

    addGuitar() {
        this.modalService.openGuitarAddOrEditModal({
            guitar: null,
            type: null
        }).result.then((guitar: Guitar) => {
                console.log(guitar);
        }).catch(() => { })
    }

    changeDisplayAmount() {
        this.modalService.openDisplayAmountModal({ amount: this.pagingService.itemsToShow }).result.then((amount: number) => {
            this.pagingService.itemsToShow = amount;
        }).catch(() => { })
    }
}