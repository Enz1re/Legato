import { Price } from "../../../Models/models";
import { ElectricGuitar } from "../../../Models/models";

import { IGuitarService } from "../../../Interfaces/interfaces";


export class ElectricController implements ng.IController {
    private guitars: ElectricGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    private error = false;
    static $inject = ["$scope", "ElectricGuitarService"];

    constructor($scope: ng.IScope, private service: IGuitarService<ElectricGuitar>) {
        this.loadGuitarList();

        $scope.$on("electric", (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sortBy = params.sortBy;
            this.sortDirection = params.sortDirection;
        });
    }

    private loadGuitarList() {
        this.service.getAllGuitars().then(guitars => {
            this.guitars = guitars;
        }).catch(err => {
            this.error = true;
        });
    }
}