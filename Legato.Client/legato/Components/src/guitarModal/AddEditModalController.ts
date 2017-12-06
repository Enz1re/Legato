import { Guitar } from "../../../Models/models";

import { Constants } from "../../../Constants";


export class AddEditModalController {
    options: string[];
    type: string;
    mode: "Add" | "Edit";
    guitar: Guitar;
    static $inject = ["$uibModalInstance", "guitar", "type"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, guitar: Guitar, type: string) {
        if (guitar) {
            this.guitar = guitar;
            this.mode = "Edit";
        } else {
            this.guitar = new Guitar();
            this.mode = "Add";
        }

        if (type) {
            this.type = type;
        }
        console.log()
        this.options = [
            Constants.CLASSICAL,
            Constants.WESTERN,
            Constants.ELECTRIC,
            Constants.BASS
        ];
    }

    onOkButtonClicked() {
        this.$uibModalInstance.close(this.guitar);
    }

    onCancelButtonClicked() {
        this.$uibModalInstance.dismiss();
    }
}