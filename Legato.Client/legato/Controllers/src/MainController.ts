import { Vendor } from '../../Models/Vendor';
import { Price } from '../../Models/Price';
import { HttpService } from '../../Services/services-module';


export default class MainController implements ng.IController {
    private price: Price = new Price();
    private vendors: Vendor[] = [];
    private sortName = "Vendor";
    private $$activeTabName = "Classical acoustic";
    static $inject = ["$scope", "HttpService"];

    constructor(private $scope: ng.IScope, private http: HttpService) {
        
    }

    refreshVendorList(guitarTypeName: string) {
        if (this.$$activeTabName === guitarTypeName) {
            return;
        }

        this.vendors = [];
        this.$$activeTabName = guitarTypeName;

        switch (guitarTypeName) {
            case 'Classical acoustic':
                this.refreshVendorListForClassicalGuitars();
                break;
            case 'Western acoustic':
                this.refreshVendorListForWesternGuitars();
                break;
            case 'Electric':
                this.refreshVendorListForElectricGuitars();
                break;
            case 'Bass':
                this.refreshVendorListForBassGuitars();
                break;
        }
    }

    broadcastButtonClick() {
        this.$scope.$broadcast('click', [this.price, this.getCheckedVendors(), this.sortName]);
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