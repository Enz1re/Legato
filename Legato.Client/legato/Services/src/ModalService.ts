﻿import angular from "angular";

import { IModalService } from "../../Interfaces/interfaces";


export default class ModalService implements IModalService {
    static $inject = ["$uibModal"];

    constructor(private $uibModal: ng.ui.bootstrap.IModalService) {

    }

    openGuitarModal(resolve: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance {
        return this.$uibModal.open({
            animation: true,
            controller: "GuitarModalController",
            controllerAs: "modalCtrl",
            templateUrl: "legato/Components/src/guitarModal/guitarModal.html",
            bindToController: true,
            resolve: resolve
        });
    }

    openLoginModal(resolve: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance {
        return this.$uibModal.open({
            animation: true,
            controller: "LoginModalController",
            controllerAs: "loginModalCtrl",
            templateUrl: "legato/Components/src/login/loginModal.html",
            resolve: resolve
        });
    }
}