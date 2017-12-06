import { Guitar } from "../../Models/models";

import { IManageService, IGuitarResource } from "../../Interfaces/interfaces";


export default class ManageService implements IManageService {
    static $inject = ["GuitarResource"];

    constructor(private guitarResource: IGuitarResource) {

    }

    addGuitar(guitar: Guitar) {
        return this.guitarResource.add(guitar);
    }

    removeGuitar(guitar: Guitar) {
        return this.guitarResource.delete(guitar);
    }

    editGuitarCharacteristics(guitar: Guitar) {
        return this.guitarResource.edit(guitar);
    }
}