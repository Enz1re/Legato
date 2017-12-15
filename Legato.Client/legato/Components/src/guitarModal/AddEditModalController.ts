import {
    Guitar,
    ClassicalGuitar,
    WesternGuitar,
    ElectricGuitar,
    BassGuitar
} from "../../../Models/models";

import { Constants } from "../../../Constants";

import { IFileUploadService, IGuitarDataService } from "../../../Interfaces/interfaces";


export class AddEditModalController {
    options: string[];
    type: string;
    mode: "Add" | "Edit";
    guitar: Guitar;
    static $inject = ["$uibModalInstance", "FileUploadService", "GuitarDataService", "guitar", "type"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, private fileUpload: IFileUploadService, private guitarData: IGuitarDataService,
                guitar: Guitar, type: string) {
        this.type = type;

        if (guitar) {
            this.mode = "Edit";
            this.guitar = guitar;
            // this.fileUpload.file.url = guitar.imgPath;
        } else {
            this.mode = "Add";
            switch (this.type) {
                case Constants.CLASSICAL:
                    this.guitar = new ClassicalGuitar();
                    break;
                case Constants.WESTERN:
                    this.guitar = new WesternGuitar();
                    break;
                case Constants.ELECTRIC:
                    this.guitar = new ElectricGuitar();
                    break;
                case Constants.BASS:
                    this.guitar = new BassGuitar();
                    break;
            }
        }

        this.options = [
            Constants.CLASSICAL,
            Constants.WESTERN,
            Constants.ELECTRIC,
            Constants.BASS
        ];
    }

    uploadFile(file) {
        
    }

    onOkButtonClicked() {
        if (!this.guitar.imgPath) {
            this.guitar.imgPath = "Content/img/guitar-placeholder.jpg";
        }

        this.$uibModalInstance.close({ guitar: this.guitar, type: this.type });
    }

    onCancelButtonClicked() {
        this.$uibModalInstance.dismiss();
    }
}