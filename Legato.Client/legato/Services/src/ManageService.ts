import { Guitar } from "../../Models/models";

import { IManageService, IGuitarResource } from "../../Interfaces/interfaces";


export default class ManageService implements IManageService {
    static $inject = ["GuitarResource"];

    constructor(private guitarResource: IGuitarResource) {

    }

    addGuitar(guitar: Guitar, type: string) {
        return this.guitarResource.add(guitar, type);
    }

    removeGuitar(guitar: Guitar, type: string) {
        return this.guitarResource.delete(guitar, type);
    }

    editGuitarCharacteristics(guitar: Guitar, type: string) {
        return this.guitarResource.edit(guitar, type);
    }

    getDisplayAmount() {
        return this.guitarResource.getDisplayAmount();
    }

    changeDisplayAmount(amount: number) {
        return this.guitarResource.changeDisplayAmount(amount);
    }
}