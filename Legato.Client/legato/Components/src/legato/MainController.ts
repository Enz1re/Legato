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
    activeTab = Constants.CLASSICAL;
    static $inject = ["$scope", "VendorService"];

    constructor(private $scope: ng.IScope, private service: IVendorService) {
        this.filtering[Constants.CLASSICAL] = {
            price: new Price(),
            sorting: new Sorting()
        };
        this.filtering[Constants.WESTERN] = {
            price: new Price(),
            sorting: new Sorting()
        };
        this.filtering[Constants.ELECTRIC] = {
            price: new Price(),
            sorting: new Sorting()
        };
        this.filtering[Constants.BASS] = {
            price: new Price(),
            sorting: new Sorting()
        };

        this.refreshVendorListForClassicalGuitars();
    }

    refreshVendorList(guitarTypeName: string) {
        if (this.activeTab === guitarTypeName) {
            return;
        }
        
        this.vendors = [];
        this.activeTab = guitarTypeName;

        // set price values to null to clean up input fields
        if (this.filtering[this.activeTab].price.from === undefined) {
            this.filtering[this.activeTab].price.from = null;
        }
        if (this.filtering[this.activeTab].price.to === undefined) {
            this.filtering[this.activeTab].price.to = null;
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
    }

    broadcastButtonClick() {
        const checkedVendors = this.getCheckedVendors();

        this.$scope.$broadcast(this.activeTab, {
            // Don't pass price filter if the filter object is not null, but From and To values are null
            price: this.filtering[this.activeTab].price.from && this.filtering[this.activeTab].price.to ? this.filtering[this.activeTab].price : null,
            // Don't pass vendor filter if all vendors are checked
            vendors: checkedVendors.length !== this.vendors.length ? checkedVendors : null,
            sorting: this.filtering[this.activeTab].sorting
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