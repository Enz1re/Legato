export class YesNoModalController {
    text: string;
    static $inject = ["$uibModalInstance", "text"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, text: string) {
        this.text = text;
    }

    onYesButtonClicked() {
        this.$uibModalInstance.close();
    }

    onNoButtonClicked() {
        this.$uibModalInstance.dismiss();
    }
}