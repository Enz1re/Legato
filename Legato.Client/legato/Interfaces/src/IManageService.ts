import { Guitar } from "../../Models/models";


export interface IManageService<TGuitar extends Guitar> {
    addGuitar(guitar: TGuitar): ng.IPromise<any>;
    removeGuitar(guitar: TGuitar): ng.IPromise<any>;
    editGuitarCharacteristics(guitar: TGuitar): ng.IPromise<any>;
}