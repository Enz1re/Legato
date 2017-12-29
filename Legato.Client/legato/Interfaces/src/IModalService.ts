import { UserViewModel, CompromisedAttempt } from "../../Models/models";


export interface IModalService {
    openGuitarModal(resolve?: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance;
    openLoginModal(resolve?: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance;
    openGuitarAddOrEditModal(resolve?: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance;
    openYesNoDialog(text: string): ng.ui.bootstrap.IModalServiceInstance;
    openDisplayAmountModal(resolve?: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance;
    openAlertModal(text: string, mode: "success" | "info" | "warning" | "danger"): ng.ui.bootstrap.IModalServiceInstance;
    openUserModal(): ng.ui.bootstrap.IModalServiceInstance;
    openCompromisedAttemptsModal(compromisedAttempts: CompromisedAttempt[]): ng.ui.bootstrap.IModalServiceInstance;
}