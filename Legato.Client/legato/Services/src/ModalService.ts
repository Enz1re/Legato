import { IModalService } from "../../Interfaces/interfaces";


export default class ModalService implements IModalService {
    static $inject = ["$uibModal"];

    constructor(private $uibModal: ng.ui.bootstrap.IModalService) {

    }

    open(resolve: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance {
        return this.$uibModal.open({
            animation: true,
            component: "GuitarModal",
            resolve: resolve
        });
    }
}