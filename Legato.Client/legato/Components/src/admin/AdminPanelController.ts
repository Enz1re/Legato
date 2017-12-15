import { Guitar } from "../../../Models/models";

import {
    IModalService,
    IManageService,
    IPagingService,
    IUpdateService,
    IRoutingService
} from "../../../Interfaces/interfaces";


export class AdminPanelController {
    static $inject = ["ManageService", "ModalService", "PagingService", "UpdateService", "RoutingService"];

    constructor(private manageService: IManageService, private modalService: IModalService, private pagingService: IPagingService,
                private updateService: IUpdateService, private routingService: IRoutingService) {

    }

    addGuitar() {
        this.modalService.openGuitarAddOrEditModal({
            guitar: null,
            type: () => this.routingService.urlSegments[1]
        }).result.then(resp => {
            this.manageService.addGuitar(resp.guitar, resp.type).then(() => {
                this.updateService.updateLastPage();
            }).catch(() => {
                this.modalService.openAlertModal("Failed to add new guitar", "danger").result.catch(() => { });
            });
        }).catch(() => { });
    }

    changeDisplayAmount() {
        this.modalService.openDisplayAmountModal({ amount: this.pagingService.itemsToShow }).result.then((amount: number) => {
            this.manageService.changeDisplayAmount(amount).then(() => {
                this.pagingService.itemsToShow = amount;
                this.updateService.updateCurrentPage();
            }).catch(() => {
                this.modalService.openAlertModal("Failed to change display amount", "danger").result.catch(() => { });
            })
        }).catch(() => { });
    }
}