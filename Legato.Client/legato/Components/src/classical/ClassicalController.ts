import { Price } from "../../../Models/models";
import { ClassicalGuitar } from "../../../Models/models";
import { Paging } from "../../../Models/models";

import { IGuitarService } from "../../../Interfaces/interfaces";


export class ClassicalController implements ng.IController {
    private guitars: ClassicalGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    private error = false;
    private paging: Paging = new Paging(0, 20);
    static $inject = ["$scope", "ClassicalGuitarService"];

    constructor($scope: ng.IScope, private service: IGuitarService<ClassicalGuitar>) {
        this.init();
        
        $scope.$on("classical", (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.loadGuitarList();
        });
    }

    onPageChanged() {
        this.paging.lowerBound = this.paging.currentPage * this.paging.itemsToShow;
        this.paging.upperBound = this.paging.currentPage * this.paging.itemsToShow + 20;
        this.loadGuitarList();
    }

    private init() {
        this.service.getAmount().then(amount => {
            this.paging.total = amount;
        }).catch(err => {
            this.error = true;
        });

        this.loadGuitarList();
    }

    private loadGuitarList() {
        this.service.getGuitars(this.price, this.vendors, this.paging).then(guitars => {
            this.guitars = guitars;
        }).catch(err => {
            this.error = true;
        });
    }
}