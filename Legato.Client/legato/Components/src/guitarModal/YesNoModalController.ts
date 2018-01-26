export class YesNoModalController {
    static $inject = ["$uibModalInstance", "text"];
    text: string;

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