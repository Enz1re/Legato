import {
    User,
    Guitar,
    CompromisedAttempt
} from "../../../Models/models";

import {
    IUserService,
    IClaimService,
    IModalService,
    IManageService,
    IPagingService,
    IUpdateService,
    IRoutingService,
} from "../../../Interfaces/interfaces";


export class AdminPanelController {
    compromisedAttempts: CompromisedAttempt[] = [];
    static $inject = ["ManageService", "ModalService", "PagingService", "UpdateService", "RoutingService", "UserService", "ClaimService"];

    constructor(private manageService: IManageService, private modalService: IModalService, private pagingService: IPagingService, private updateService: IUpdateService,
                private routingService: IRoutingService, private userService: IUserService, private claimService: IClaimService) {
        if (userService.currentUser.role === "Superuser") {
            userService.getCompromisedAttempts().then(result => {
                this.compromisedAttempts = result.compromisedAttempts;
            });
        }
    }

    addGuitar() {
        this.modalService.openGuitarAddOrEditModal({
            guitar: null,
            type: () => this.routingService.urlSegments[1]
        }).result.then(resp => {
            this.claimService.canAddGuitar().then(result => {
                if (result) {
                    this.manageService.addGuitar(resp.guitar, resp.type).then(() => {
                        this.updateService.updateLastPage();
                    }).catch(() => {
                        this.modalService.openAlertModal("Failed to add new guitar", "danger").result.catch(() => { });
                    });
                } else {
                    this.modalService.openAlertModal("You are not authorized to perform this action", "danger").result.catch(() => { });
                }
            });
        }).catch(() => { });
    }

    changeDisplayAmount() {
        this.modalService.openDisplayAmountModal({ amount: this.pagingService.itemsToShow }).result.then((amount: number) => {
            this.claimService.canChangeDisplayAmount().then(result => {
                if (result) {
                    this.manageService.changeDisplayAmount(amount).then(() => {
                        this.pagingService.itemsToShow = amount;
                        this.updateService.updateCurrentPage();
                    }).catch(() => {
                        this.modalService.openAlertModal("Failed to change display amount", "danger").result.catch(() => { });
                    });
                } else {
                    this.modalService.openAlertModal("You are not authorized to perform this action", "danger").result.catch(() => { });
                }
            });
        }).catch(() => { });
    }

    listUsers() {
        this.modalService.openUserModal(this.userService.getUsers()).result.then(() => {

        }).catch(() => { });
    }

    showCompromisedAttempts() {
        this.modalService.openCompromisedAttemptsModal(this.compromisedAttempts).result.then(() => {

        }).catch(() => { });
    }
}