import {
    Guitar,
    ClassicalGuitar,
    WesternGuitar,
    ElectricGuitar,
    BassGuitar
} from "../../../Models/models";

import { GuitarNameConfig } from "../../../Models/models";

import { IFileUploadService, IGuitarDataService } from "../../../Interfaces/interfaces";


export class AddEditModalController {
    options: string[];
    type: string;
    mode: "Add" | "Edit";
    guitar: Guitar;
    static $inject = ["$uibModalInstance", "FileUploadService", "GuitarDataService", "GuitarName", "guitar", "type"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, private fileUpload: IFileUploadService, private guitarData: IGuitarDataService,
                private guitarName: GuitarNameConfig, guitar: Guitar, type: string) {
        this.type = type;

        if (guitar) {
            this.mode = "Edit";
            this.guitar = guitar;
            // this.fileUpload.file.url = guitar.imgPath;
        } else {
            this.mode = "Add";
            switch (this.type) {
                case this.guitarName.classical:
                    this.guitar = new ClassicalGuitar();
                    break;
                case this.guitarName.western:
                    this.guitar = new WesternGuitar();
                    break;
                case this.guitarName.electric:
                    this.guitar = new ElectricGuitar();
                    break;
                case this.guitarName.bass:
                    this.guitar = new BassGuitar();
                    break;
            }
        }

        this.options = [
            this.guitarName.classical,
            this.guitarName.western,
            this.guitarName.electric,
            this.guitarName.bass
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