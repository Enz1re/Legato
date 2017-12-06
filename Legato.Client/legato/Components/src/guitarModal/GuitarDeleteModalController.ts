import { Guitar } from "../../../Models/models";


export class GuitarDeleteModalController {
    guitar: Guitar;
    static $inject = ["$uibModalInstance", "guitar"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, guitar: Guitar) {
        this.guitar = guitar;
    }

    onOkButtonClicked() {
        this.$uibModalInstance.close();
    }

    onCancelButtonClicked() {
        this.$uibModalInstance.dismiss();
    }
}