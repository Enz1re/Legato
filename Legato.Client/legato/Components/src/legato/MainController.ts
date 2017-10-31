import { Price } from "../../../Models/models";
import { Vendor } from "../../../Models/models";
import { Sorting } from "../../../Models/models";

import { IVendorService } from "../../../Interfaces/interfaces";


export class MainController implements ng.IController {
    private price: Price = new Price();
    private vendors: Vendor[] = [];
    private sorting: Sorting = new Sorting();
    private error = false;
    private $$activeTab = "classical";
    static $inject = ["$scope", "VendorService"];

    constructor(private $scope: ng.IScope, private vendorService: IVendorService) {
        this.refreshVendorListForClassicalGuitars();
        this.sorting = { required: false, name: "Vendor", direction: "Ascending" };
    }

    refreshVendorList(guitarTypeName: string) {
        if (this.$$activeTab === guitarTypeName) {
            return;
        }

        this.vendors = [];
        this.$$activeTab = guitarTypeName;

        switch (guitarTypeName) {
            case "classical":
                this.refreshVendorListForClassicalGuitars();
                break;
            case "western":
                this.refreshVendorListForWesternGuitars();
                break;
            case "electric":
                this.refreshVendorListForElectricGuitars();
                break;
            case "bass":
                this.refreshVendorListForBassGuitars();
                break;
        }
    }

    broadcastButtonClick() {
        // copy all values to prevent model change inside child controllers
        this.$scope.$broadcast(this.$$activeTab, {
            price: { from: this.price.from, to: this.price.to },
            vendors: this.getCheckedVendors(),
            sortBy: this.sorting.required ? this.sorting.name.toString() : "",
            sortDirection: this.sorting.required ? this.sorting.direction.toString() : ""
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
        this.vendorService.getClassicalGuitarVendors().then(vendors => {
            this.vendors = vendors;
        }).catch(err => {
            this.error = true;
        });
    }

    private refreshVendorListForWesternGuitars() {
        this.vendorService.getWesternGuitarVendors().then(vendors => {
            this.vendors = vendors;
        }).catch(err => {
            this.error = true;
        });
    }

    private refreshVendorListForElectricGuitars() {
        this.vendorService.getElectricGuitarVendors().then(vendors => {
            this.vendors = vendors;
        }).catch(err => {
            this.error = true;
        });
    }

    private refreshVendorListForBassGuitars() {
        this.vendorService.getBassGuitarVendors().then(vendors => {
            this.vendors = vendors;
        }).catch(err => {
            this.error = true;
        });
    }
}