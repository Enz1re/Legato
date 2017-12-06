import { Guitar } from "../../Models/models";


export interface IManageService {
    addGuitar(guitar: Guitar): ng.IPromise<any>;
    removeGuitar(guitar: Guitar): ng.IPromise<any>;
    editGuitarCharacteristics(guitar: Guitar): ng.IPromise<any>;
}