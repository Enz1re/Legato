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
    static $inject = ["$scope", "$window", "ClassicalGuitarService"];

    constructor($scope: ng.IScope, private $window: ng.IWindowService, private service: IGuitarService<ClassicalGuitar>) {
        this.init();
        this.loadGuitarList();
        
        $scope.$on("classical", (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sortBy = params.sortBy;
            this.sortDirection = params.sortDirection;
        });
    }

    onPageChanged(isLowerPagination: boolean = false) {
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
    }

    private loadGuitarList() {
        this.service.getAllGuitars(this.paging).then(guitars => {
            this.guitars = guitars;
        }).catch(err => {
            this.error = true;
        });
    }
}