import {
    Price,
    Vendor,
    Sorting
} from "../../../Models/models";

import { ClassicalController } from "../../../Components/src/classical/ClassicalController";

import { IVendorService } from "../../../Interfaces/interfaces";

import { Constants } from "../../../Constants";


export class MainController implements ng.IController {
    filtering: any = {};
    vendors: Vendor[] = [];
    error = false;
    activeTab: string;
    price: Price = new Price();
    sorting: Sorting = new Sorting();
    static $inject = ["$scope", "$location", "$state", "VendorService"];

    constructor(private $scope: ng.IScope, private $location: ng.ILocationService, private $state: ng.ui.IStateService, private service: IVendorService) {
        this.refreshVendorList($location.path().split('/')[1], false);
    }

    refreshVendorList(guitarTypeName: string, needChangeState: boolean = true) {
        if (this.activeTab === guitarTypeName) {
            return;
        }
        
        this.vendors = [];
        this.activeTab = guitarTypeName;

        // set price values to null to clean up input fields
        if (this.price.from === undefined) {
            this.price.from = null;
        }
        if (this.price.to === undefined) {
            this.price.to = null;
        }
        
        switch (guitarTypeName) {
            case Constants.CLASSICAL:
                this.refreshVendorListForClassicalGuitars();
                break;
            case Constants.WESTERN:
                this.refreshVendorListForWesternGuitars();
                break;
            case Constants.ELECTRIC:
                this.refreshVendorListForElectricGuitars();
                break;
            case Constants.BASS:
                this.refreshVendorListForBassGuitars();
                break;
        }

        if (needChangeState) {
            this.$state.go(guitarTypeName);
        }
    }

    broadcastRequestEvent() {
        const checkedVendors = this.getCheckedVendors();

        this.$scope.$broadcast(this.activeTab, {
            // Don't pass price filter if the filter object is not null, but From and To values are null
            price: this.price.from && this.price.to ? this.price : null,
            // Don't pass vendor filter if all vendors are checked
            vendors: checkedVendors.length !== this.vendors.length ? checkedVendors : null,
            sorting: this.sorting
        });
    }

    private getCheckedVendors() {
        let vendors = [];

        for (let v of this.vendors) {
            if (v.isSelected) {
                vendors.push(v.name);
            }
        }
        
        return vendors;
    }

    private refreshVendorListForClassicalGuitars() {
        this.service.getClassicalGuitarVendors().then(vendors => {
            this.vendors = vendors;
        }).catch(err => {
            this.error = true;
        });
    }

    private refreshVendorListForWesternGuitars() {
        this.service.getWesternGuitarVendors().then(vendors => {
            this.vendors = vendors;
        }).catch(err => {
            this.error = true;
        });
    }

    private refreshVendorListForElectricGuitars() {
        this.service.getElectricGuitarVendors().then(vendors => {
            this.vendors = vendors;
        }).catch(err => {
            this.error = true;
        });
    }

    private refreshVendorListForBassGuitars() {
        this.service.getBassGuitarVendors().then(vendors => {
            this.vendors = vendors;
        }).catch(err => {
            this.error = true;
        });
    }
}