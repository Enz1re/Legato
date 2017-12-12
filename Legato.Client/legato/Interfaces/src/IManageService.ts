import { Guitar } from "../../Models/models";


export interface IManageService {
    addGuitar(guitar: Guitar, type: string): ng.IPromise<any>;
    removeGuitar(guitar: Guitar, type: string): ng.IPromise<any>;
    editGuitarCharacteristics(guitar: Guitar, type: string): ng.IPromise<any>;
    getDisplayAmount(): ng.IPromise<number>;
    changeDisplayAmount(amount: number): ng.IPromise<any>;
}