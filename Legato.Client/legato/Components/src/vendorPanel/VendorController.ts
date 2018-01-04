import { Vendor, GuitarNameConfig } from "../../../Models/models";

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
        let promise: ng.IPromise<Vendor[]>;
        switch (guitarName) {
            case this.guitarNames.classical:
                promise = this.vendorService.getClassicalGuitarVendors();
                break;
            case this.guitarNames.western:
                promise = this.vendorService.getWesternGuitarVendors();
                break;
            case this.guitarNames.electric:
                promise = this.vendorService.getElectricGuitarVendors();
                break;
            case this.guitarNames.bass:
                promise = this.vendorService.getBassGuitarVendors();
                break;
        }

        return promise.then(vendors => {
            this.updateService.filter.vendors = vendors;
        });
    }
}