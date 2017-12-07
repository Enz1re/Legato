import { Guitar } from "../../../Models/models";

import { Constants } from "../../../Constants";

import { IFileUploadService } from "../../../Interfaces/interfaces";


export class AddEditModalController {
    options: string[];
    type: string;
    mode: "Add" | "Edit";
    guitar: Guitar;
    static $inject = ["$uibModalInstance", "FileUploadService", "guitar", "type"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, private fileUpload: IFileUploadService, guitar: Guitar, type: string) {
        if (guitar) {
            this.mode = "Edit";
            this.guitar = guitar;
            this.fileUpload.file.url = guitar.imgPath;
        } else {
            this.guitar = new Guitar();
            this.mode = "Add";
        }

        if (type) {
            this.type = type;
        }

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