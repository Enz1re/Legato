import { Price } from "../../../Models/models";
import { ClassicalGuitar } from "../../../Models/models";

import { IGuitarService } from "../../../Interfaces/interfaces";


export class ClassicalController implements ng.IController {
    private guitars: ClassicalGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    private error = false;
    static $inject = ["$scope", "ClassicalGuitarService"];

    constructor($scope: ng.IScope, private service: IGuitarService<ClassicalGuitar>) {
        this.loadGuitarList();

        $scope.$on("classical", (e, params) => {
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