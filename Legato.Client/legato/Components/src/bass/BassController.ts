import { Price } from "../../../Models/models";
import { BassGuitar } from "../../../Models/models";

import { IGuitarService } from "../../../Interfaces/interfaces";


export class BassController implements ng.IController {
    private guitars: BassGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    private error = false;
    static $inject = ["$scope", "BassGuitarService"];

    constructor($scope: ng.IScope, private service: IGuitarService<BassGuitar>) {
        this.service.getAllGuitars().then(guitars => {
            this.guitars = guitars;
        }).catch(err => {
            this.error = true;
        });

        $scope.$on("bass", (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sortBy = params.sortBy;
            this.sortDirection = params.sortDirection;
        });
    }
}