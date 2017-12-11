export class AlertModalController {
    modalContent: string;
    mode: string;
    static $inject = ["$uibModalInstance", "modalContent", "mode"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, modalContent: string, mode: string) {
        this.modalContent = modalContent;
        this.mode = mode;
    }

    onOkButtonClicked() {
        this.$uibModalInstance.close();
    }
}