import { GuitarNameConfig } from "../../../Models/models";

import {
    IFilterStateService,
    IVendorService,
    IUpdateService,
    IRoutingService,
} from "../../../Interfaces/interfaces";


export class VendorController {
    error: boolean;
    static $inject = ["$scope", "VendorService", "RoutingService", "UpdateService", "FilterStateService", "GuitarName"];

    constructor($scope: ng.IScope, private vendorService: IVendorService, routingService: IRoutingService,
                private updateService: IUpdateService, filterService: IFilterStateService, private guitarNames: GuitarNameConfig) {
        const guitarTypeName = routingService.urlSegments[1];
        this.refreshVendorList(guitarTypeName).then(() => {
            this.updateService.filter.vendors = routingService.getParamResolver().resolveVendors(this.updateService.filter.vendors);
        }).then(() => {
            $scope.$watch(() => routingService.urlSegments[1], (newValue, oldValue) => {
                if (newValue !== oldValue) {
                    if (filterService.guitarFilter[newValue].vendors) {
                        this.updateService.filter.vendors = filterService.guitarFilter[newValue].vendors;
                    } else {
                        this.refreshVendorList(newValue);
                    }
                }
            });
        });
    }

    private refreshVendorList(guitarName: string) {
        this.updateService.filter.vendors = [];
        switch (guitarName) {
            case this.guitarNames.classical:
                return this.refreshVendorListForClassicalGuitars()
            case this.guitarNames.western:
                return this.refreshVendorListForWesternGuitars();
            case this.guitarNames.electric:
                return this.refreshVendorListForElectricGuitars();
            case this.guitarNames.bass:
                return this.refreshVendorListForBassGuitars();
        }
    }

    private refreshVendorListForClassicalGuitars() {
        return this.vendorService.getClassicalGuitarVendors().then(vendors => {
            this.updateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
        });
    }

    private refreshVendorListForWesternGuitars() {
        return this.vendorService.getWesternGuitarVendors().then(vendors => {
            this.updateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
        });
    }

    private refreshVendorListForElectricGuitars() {
        return this.vendorService.getElectricGuitarVendors().then(vendors => {
            this.updateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
        });
    }

    private refreshVendorListForBassGuitars() {
        return this.vendorService.getBassGuitarVendors().then(vendors => {
            this.updateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
        });
    }
}