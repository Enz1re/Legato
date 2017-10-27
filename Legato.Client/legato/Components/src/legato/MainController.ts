import Price from '../../../Models/Price';
import Vendor from '../../../Models/Vendor';
import Sorting from '../../../Models/Sorting';

import { IHttpService } from '../../../Interfaces/interfaces';


export class MainController implements ng.IController {
    private price: Price = new Price();
    private vendors: Vendor[] = [];
    private sorting: Sorting = new Sorting();
    private error = false;
    private $$activeTab = "classical";
    private $$cache: ng.ICacheObject;
    static $inject = ["$scope", "$cacheFactory", "HttpService"];

    constructor(private $scope: ng.IScope, $cacheFactory: ng.ICacheFactoryService, private http: IHttpService) {
        this.$$cache = $cacheFactory('main');
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
            if (v.selected) {
                vendors.push(v.name);
            }
        }

        return vendors;
    }

    private refreshVendorListForClassicalGuitars() {
        let cachedVendors = this.$$cache.get<string[]>('classicalVendors');

        if (cachedVendors) {
            this.addVendors(cachedVendors);
        } else {
            this.http.getClassicalGuitarVendors().then(vendors => {
                this.$$cache.put('classicalVendors', vendors);
                this.addVendors(vendors);
            }).catch(err => {
                this.error = true;
            });
        }
    }

    private refreshVendorListForWesternGuitars() {
        let cachedVendors = this.$$cache.get<string[]>('westernVendors');

        if (cachedVendors) {
            this.addVendors(cachedVendors);
        } else {
            this.http.getWesternGuitarVendors().then(vendors => {
                this.$$cache.put('westernVendors', vendors);
                this.addVendors(vendors);
            }).catch(err => {
                this.error = true;
            });
        }
    }

    private refreshVendorListForElectricGuitars() {
        let cachedVendors = this.$$cache.get<string[]>('electricVendors');

        if (cachedVendors) {
            this.addVendors(cachedVendors);
        } else {
            this.http.getElectricGuitarVendors().then(vendors => {
                this.$$cache.put('electricVendors', vendors);
                this.addVendors(vendors);
            }).catch(err => {
                this.error = true;
            });
        }
    }

    private refreshVendorListForBassGuitars() {
        let cachedVendors = this.$$cache.get<string[]>('bassVendors');

        if (cachedVendors) {
            this.addVendors(cachedVendors);
        } else {
            this.http.getBassGuitarVendors().then(vendors => {
                this.$$cache.put('bassVendors', vendors);
                this.addVendors(vendors);
            }).catch(err => {
                this.error = true;
            });
        }
    }

    private addVendors(vendors: string[]) {
        for (let vendor of vendors) {
            this.vendors.push(new Vendor(vendor));
        }
    }
}