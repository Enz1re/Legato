import angular from "angular";

import { AddEditModalController } from "./AddEditModalController";

import {
    Guitar,
    ClassicalGuitar,
    WesternGuitar,
    ElectricGuitar,
    BassGuitar
} from "../../../Models/models";

import { GuitarNameConfig } from "../../../Models/models";

import { IFileUploadService, IGuitarDataService } from "../../../Interfaces/interfaces";

const classicalGuitar = {
    id: 0,
    vendor: { id: 0, name: "Kremona", isSelected: true },
    model: "Verea cutaway",
    mensura: 500,
    price: 1200,
    imgPath: "Content/img/Classical/kremona_verea_cutaway.png"
};

const electricGuitar = {
    id: 0,
    vendor: { id: 0, name: "B.C. Rich", isSelected: true },
    model: "Warbeast",
    mensura: 601,
    price: 20120,
    imgPath: ""
};

const guitarNameConfig: GuitarNameConfig = {
    classical: "classical",
    western: "western",
    electric: "electric",
    bass: "bass"
};


describe("AddEditModalController", () => {
    let $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance;
    let fileUpload: IFileUploadService;
    let guitarData: IGuitarDataService;
    let controllerClassical: AddEditModalController;
    let controllerWesternNull: AddEditModalController;
    let controllerElectric: AddEditModalController;
    let controllerBassNull: AddEditModalController;

    beforeEach(inject((_$q_: ng.IQService) => {
        $uibModalInstance = <ng.ui.bootstrap.IModalServiceInstance>{
            close: jasmine.createSpy("close"),
            dismiss: jasmine.createSpy("dismiss"),
            result: _$q_.when(),
            opened: _$q_.when(),
            rendered: _$q_.when(),
            closed: _$q_.when()
        };
        fileUpload = <IFileUploadService>{

        };
        guitarData = <IGuitarDataService>{
            data: {
                classical: {
                    stringTypes: ["Nylon", "Fluorocarbon"]
                },
                western: {
                    stringNumbers: [6, 7, 8, 10, 12],
                    stringCalibers: [8, 9, 10, 11, 12, 13]
                },
                electric: {
                    stringNumbers: [6, 7, 8, 10, 12],
                    soundBoxes: ["Single", "Humbucker"],
                    stringCalibers: [8, 9, 10, 11, 12, 13]
                },
                bass: {
                    stringNumbers: [1, 4, 5, 7, 8, 10],
                    soundBoxes: ["Single", "Humbucker"]
                }
            }
        };

        controllerClassical = new AddEditModalController($uibModalInstance, fileUpload, guitarData, guitarNameConfig, classicalGuitar, "classical");
        controllerWesternNull = new AddEditModalController($uibModalInstance, fileUpload, guitarData, guitarNameConfig, null, "western");
        controllerElectric = new AddEditModalController($uibModalInstance, fileUpload, guitarData, guitarNameConfig, electricGuitar, "electric");
        controllerBassNull = new AddEditModalController($uibModalInstance, fileUpload, guitarData, guitarNameConfig, null, "bass");
    }));

    it("initializes type and mode of classical guitar", () => {
        expect(controllerClassical.type).toBe("classical");
        expect(controllerClassical.mode).toBe("Edit");
        expect(angular.equals(controllerClassical.guitar, classicalGuitar));
    });

    it("initializes type and mode of null western guitar", () => {
        expect(controllerWesternNull.type).toBe("western");
        expect(controllerWesternNull.mode).toBe("Add");
        expect(angular.equals(controllerWesternNull.guitar, {}));
    });

    it("initializes type and mode of electric guitar", () => {
        expect(controllerElectric.type).toBe("electric");
        expect(controllerElectric.mode).toBe("Edit");
        expect(angular.equals(controllerElectric.guitar, electricGuitar));
    });

    it("initializes type and mode of null bass guitar", () => {
        expect(controllerBassNull.type).toBe("bass");
        expect(controllerBassNull.mode).toBe("Add");
        expect(angular.equals(controllerBassNull.guitar, {}));
    });

    it("closes modal window", () => {
        controllerClassical.onOkButtonClicked();
        expect($uibModalInstance.close).toHaveBeenCalled();
    });

    it("closes modal window and assigns default image path if no were provided", () => {
        controllerWesternNull.onOkButtonClicked();
        expect(controllerWesternNull.guitar.imgPath).toBe("Content/img/guitar-placeholder.jpg");
        expect($uibModalInstance.close).toHaveBeenCalled();
    });

    it("dismisses modal window", () => {
        controllerElectric.onCancelButtonClicked();
        expect($uibModalInstance.dismiss).toHaveBeenCalled();
    });
});