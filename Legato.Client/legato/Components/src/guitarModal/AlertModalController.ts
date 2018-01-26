export class AlertModalController {
    static $inject = ["$uibModalInstance", "modalContent", "mode"];
    modalContent: string;
    mode: string;

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, modalContent: string, mode: string) {
        this.modalContent = modalContent;
        this.mode = mode;
    }

    onOkButtonClicked() {
        this.$uibModalInstance.close();
    }
}