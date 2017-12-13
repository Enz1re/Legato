import { IModalService } from "../../Interfaces/interfaces";


export default class ModalService implements IModalService {
    static $inject = ["$uibModal"];

    constructor(private $uibModal: ng.ui.bootstrap.IModalService) {

    }

    openGuitarModal(resolve?: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance {
        return this.$uibModal.open({
            animation: true,
            controller: "GuitarModalController",
            controllerAs: "modalCtrl",
            templateUrl: "legato/Components/src/guitarModal/guitarModal.html",
            bindToController: true,
            resolve: resolve
        });
    }

    openLoginModal(resolve?: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance {
        return this.$uibModal.open({
            animation: true,
            controller: "LoginModalController",
            controllerAs: "loginModalCtrl",
            templateUrl: "legato/Components/src/login/loginModal.html",
            resolve: resolve
        });
    }

    openGuitarAddOrEditModal(resolve?: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance {
        return this.$uibModal.open({
            animation: true,
            controller: "AddEditModalController",
            controllerAs: "addeditModalCtrl",
            templateUrl: "legato/Components/src/guitarModal/addeditModal.html",
            bindToController: true,
            resolve: resolve
        });
    }

    openGuitarDeleteDialog(resolve?: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance {
        return this.$uibModal.open({
            animation: true,
            size: "sm",
            controller: "GuitarDeleteModalController",
            controllerAs: "guitarDeleteModalCtrl",
            templateUrl: "legato/Components/src/guitarModal/guitarDeleteModal.html",
            bindToController: true,
            resolve: resolve
        });
    }

    openDisplayAmountModal(resolve?: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance {
        return this.$uibModal.open({
            animation: true,
            controller: "DisplayAmountModalController",
            controllerAs: "displayAmountModalCtrl",
            templateUrl: "legato/Components/src/guitarModal/displayAmountModal.html",
            bindToController: true,
            resolve: resolve
        });
    }

    openAlertModal(text: string, mode: "success" | "info" | "warning" | "danger"): ng.ui.bootstrap.IModalServiceInstance {
        return this.$uibModal.open({
            animation: true,
            controller: "AlertModalController",
            controllerAs: "alertModalCtrl",
            templateUrl: "legato/Components/src/guitarModal/alertModal.html",
            bindToController: true,
            resolve: {
                modalContent: () => text,
                mode: () => mode
            }
        });
    }
}