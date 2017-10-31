﻿import { Price } from "../../../Models/models";
import { WesternGuitar } from "../../../Models/models";

import { IGuitarService } from "../../../Interfaces/interfaces";


export class WesternController implements ng.IController {
    private guitars: WesternGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    private error = false;
    static $inject = ["$scope", "WesternGuitarService"];

    constructor($scope: ng.IScope, private service: IGuitarService<WesternGuitar>) {
        this.loadGuitarList();

        $scope.$on("western", (e, params) => {
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