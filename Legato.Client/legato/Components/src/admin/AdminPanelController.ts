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
    compromisedAttempts: CompromisedAttempt[];
    static $inject = ["ManageService", "ModalService", "PagingService", "UpdateService", "RoutingService", "UserService", "ClaimService"];

    constructor(private manageService: IManageService, private modalService: IModalService, private pagingService: IPagingService, private updateService: IUpdateService,
                private routingService: IRoutingService, private userService: IUserService, private claimService: IClaimService) {
        if (claimService.claims.getCompromisedAttempts) {
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
            this.manageService.addGuitar(resp.guitar, resp.type).then(() => {
                this.updateService.updateLastPage();
            }).catch(err => {
                this.modalService.openAlertModal(err.data.message, "danger").result.catch(() => { });
            });
        }).catch(() => { });
    }

    changeDisplayAmount() {
        const prevAmountValue = this.pagingService.itemsToShow;
        this.modalService.openDisplayAmountModal({ amount: prevAmountValue }).result.then((newAmount: number) => {
            if (prevAmountValue !== newAmount) {
                this.manageService.changeDisplayAmount(newAmount).then(() => {
                    this.pagingService.itemsToShow = newAmount;
                    this.updateService.updateCurrentPage();
                }).catch(err => {
                    this.modalService.openAlertModal(err.data.message, "danger").result.catch(() => { });
                });
            }
         }).catch(() => { });
    }

    listUsers() {
        this.modalService.openUserModal().result.then(() => {

        }).catch(() => { });
    }

    showCompromisedAttempts() {
        this.modalService.openCompromisedAttemptsModal(this.compromisedAttempts).result.then(isPristine => {
            if (!isPristine) {
                this.userService.getCompromisedAttempts().then(result => {
                    this.compromisedAttempts = result.compromisedAttempts;
                });
            }
        }).catch(() => { });
    }
}