import {
    Price,
    Vendor,
    Sorting
} from "../../../Models/models";

import { ClassicalController } from "../../../Components/src/classical/ClassicalController";

import { IVendorService, IRoutingService } from "../../../Interfaces/interfaces";

import { Constants } from "../../../Constants";


export class MainController implements ng.IController {
    filtering: any = {};
    vendors: Vendor[] = [];
    error = false;
    activeTab: string;
    price: Price = new Price();
    sorting: Sorting = new Sorting();
    static $inject = ["$scope", "RoutingService", "VendorService"];

    constructor(private $scope: ng.IScope, private routingService: IRoutingService, private service: IVendorService) {
        routingService.transition().then(name => {
            const urlParamResolver = routingService.getParamResolver();

            this.price = urlParamResolver.resolvePrice();
            this.sorting = urlParamResolver.resolveSorting();
            this.activeTab = name;

            this.initVendorList(name).then(() => {
                this.vendors = urlParamResolver.resolveVendors(this.vendors);
            });

            this.broadcastRequestEvent();
        }).catch(err => { });
    }

    refreshVendorList(click, guitarTypeName: string) {
        if (this.activeTab === guitarTypeName || click === undefined) {
            return;
        }

        // set price values to null to clean up input fields
        if (this.price.from === undefined) {
            this.price.from = null;
        }
        if (this.price.to === undefined) {
            this.price.to = null;
        }

        this.initVendorList(guitarTypeName);

        this.routingService.redirect(this.activeTab, this.routingService.queryParams());
    }

    broadcastRequestEvent() {
        const checkedVendors = this.getCheckedVendors();
        
        this.$scope.$broadcast(this.activeTab, {
            price: this.price,
            vendors: checkedVendors.length !== this.vendors.length ? checkedVendors : null,
            sorting: this.sorting
        });
    }

    // this method is called only in constructor because of state change that is invoked when the first tab on page load is seleted
    private initVendorList(guitarTypeName: string) {
        this.vendors = [];
        this.activeTab = guitarTypeName;

        switch (guitarTypeName) {
            case Constants.CLASSICAL:
                return this.refreshVendorListForClassicalGuitars()
            case Constants.WESTERN:
                return this.refreshVendorListForWesternGuitars();
            case Constants.ELECTRIC:
                return this.refreshVendorListForElectricGuitars();
            case Constants.BASS:
                return this.refreshVendorListForBassGuitars();
        }
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
        return this.service.getClassicalGuitarVendors().then(vendors => {
            this.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }

    private refreshVendorListForWesternGuitars() {
        return this.service.getWesternGuitarVendors().then(vendors => {
            this.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }

    private refreshVendorListForElectricGuitars() {
        return this.service.getElectricGuitarVendors().then(vendors => {
            this.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }

    private refreshVendorListForBassGuitars() {
        return this.service.getBassGuitarVendors().then(vendors => {
            this.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }
}