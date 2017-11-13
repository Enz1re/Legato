import {
    Price,
    Vendor,
    Sorting
} from "../../../Models/models";

import { ClassicalController } from "../../../Components/src/classical/ClassicalController";

import { IVendorService, IUrlParamResolverFactoryService } from "../../../Interfaces/interfaces";

import { Constants } from "../../../Constants";


export class MainController implements ng.IController {
    filtering: any = {};
    vendors: Vendor[] = [];
    error = false;
    activeTab: string;
    price: Price = new Price();
    sorting: Sorting = new Sorting();
    static $inject = ["$scope", "$state", "VendorService", "UrlParamResolverFactoryService"];

    constructor(private $scope: ng.IScope, private $state: ng.ui.IStateService, private service: IVendorService, private resolverFactory: IUrlParamResolverFactoryService) {
        const gType = $state.current.name;
        const urlParamResolver = resolverFactory.get();

        this.price = urlParamResolver.resolvePrice();
        this.sorting = urlParamResolver.resolveSorting();

        this.activeTab = gType;
        this.refreshVendorList(gType, false);

        this.broadcastRequestEvent();
    }

    refreshVendorList(guitarTypeName: string, needChangeState = true) {
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
        
        let promise;
        switch (guitarTypeName) {
            case Constants.CLASSICAL:
                promise = this.refreshVendorListForClassicalGuitars()
                break;
            case Constants.WESTERN:
                promise = this.refreshVendorListForWesternGuitars();
                break;
            case Constants.ELECTRIC:
                promise = this.refreshVendorListForElectricGuitars();
                break;
            case Constants.BASS:
                promise = this.refreshVendorListForBassGuitars();
                break;
        }

        promise.then(() => {
            this.resolverFactory.get().resolveVendors(this.vendors);
        });

        if (needChangeState) {
            this.$state.go(guitarTypeName);
        }
    }

    broadcastRequestEvent() {
        const checkedVendors = this.getCheckedVendors();

        this.$scope.$broadcast(this.activeTab, {
            price: this.price,
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