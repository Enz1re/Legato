import { Guitar } from "../../../Models/models";


export class DisplayAmountModalController {
    amount: number;
    static $inject = ["$uibModalInstance", "amount"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, amount: number) {
        this.amount = amount;
    }

    onOkButtonClicked() {
        this.$uibModalInstance.close(this.amount);
    }

    onCancelButtonClicked() {
        this.$uibModalInstance.dismiss();
    }
}