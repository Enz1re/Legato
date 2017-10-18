import Price from '../../Models/Price';
import Vendor from '../../Models/Vendor';
import Sorting from '../../Models/Sorting';
import { HttpService } from '../../Services/services-module';


export default class MainController implements ng.IController {
    private price: Price = new Price();
    private vendors: Vendor[] = [];
    private sorting: Sorting = new Sorting();
    private $$activeTab = "classical";
    static $inject = ["$scope", "HttpService"];

    constructor(private $scope: ng.IScope, private http: HttpService) {
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
            case 'classical':
                this.refreshVendorListForClassicalGuitars();
                break;
            case 'western':
                this.refreshVendorListForWesternGuitars();
                break;
            case 'electric':
                this.refreshVendorListForElectricGuitars();
                break;
            case 'bass':
                this.refreshVendorListForBassGuitars();
                break;
        }
    }

    broadcastButtonClick() {
        // copy all values to prevent model inside child controllers
        this.$scope.$broadcast(this.$$activeTab, {
            price: { from: this.price.from, to: this.price.to },
            vendors: this.getCheckedVendors(),
            sortBy: this.sorting.required ? this.sorting.name.toString() : "",
            sortDirection: this.sorting.direction
        });
    }

    private getCheckedVendors() {
        let vendors = [];

        for (let v of this.vendors) {
            if (v.selected) {
                vendors.push(v.name);
            }
        }

        return vendors;
    }

    private refreshVendorListForClassicalGuitars() {
        this.http.getClassicalGuitarVendors().then(vendors => {
            this.addVendors(vendors);
        });
    }

    private refreshVendorListForWesternGuitars() {
        this.http.getWesternGuitarVendors().then(vendors => {
            this.addVendors(vendors);
        });
    }

    private refreshVendorListForElectricGuitars() {
        this.http.getElectricGuitarVendors().then(vendors => {
            this.addVendors(vendors);
        });
    }

    private refreshVendorListForBassGuitars() {
        this.http.getBassGuitarVendors().then(vendors => {
            this.addVendors(vendors);
        });
    }

    private addVendors(vendors: string[]) {
        for (let vendor of vendors) {
            this.vendors.push(new Vendor(vendor));
        }
    }
}