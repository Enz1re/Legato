import {
    Price,
    Vendor,
    Sorting
} from "../../../Models/models";

import {
    IFilterService,
    IVendorService,
    IRoutingService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";

import { Constants } from "../../../Constants";


export class MainController implements ng.IController {
    error = false;
    activeTab: string;
    static $inject = ["RoutingService", "FilterUpdateService", "FilterService", "VendorService"];

    constructor(private routingService: IRoutingService, private filterUpdateService: IFilterUpdateService,
                private filterService: IFilterService, private service: IVendorService) {
        const name = routingService.urlSegments[1];
        this.initVendorList(name).then(() => {
            const urlParamResolver = routingService.getParamResolver();

            this.activeTab = name;
            this.filterUpdateService.filter.price = urlParamResolver.resolvePrice();
            this.filterUpdateService.filter.sorting = urlParamResolver.resolveSorting();
            this.filterUpdateService.filter.vendors = urlParamResolver.resolveVendors(this.filterUpdateService.filter.vendors);
        });
    }

    checkTab(click, guitarTypeName: string) {
        if (this.activeTab === guitarTypeName || click === undefined) {
            return;
        }

        this.activeTab = guitarTypeName;
        this.filterUpdateService.filter.price = this.filterService.guitarFilter[guitarTypeName].price || new Price();
        this.filterUpdateService.filter.sorting = this.filterService.guitarFilter[guitarTypeName].sorting || new Sorting();

        if (!this.filterService.guitarFilter[guitarTypeName].vendors) {
            this.initVendorList(guitarTypeName);
        } else {
            this.filterUpdateService.filter.vendors = this.filterService.guitarFilter[guitarTypeName].vendors;
        }
        
        this.routingService.redirect(this.activeTab, this.filterService.guitarFilter[guitarTypeName].params || { page: "1" });
    }

    onTabDeselected(event, guitarTypeName: string) {
        if (event === undefined) {
            return;
        }

        this.filterService.guitarFilter[guitarTypeName].params = { ...this.routingService.queryParams };
        this.filterService.guitarFilter[guitarTypeName].price = { ...this.filterUpdateService.filter.price };
        this.filterService.guitarFilter[guitarTypeName].vendors = [ ...this.filterUpdateService.filter.vendors ];
        this.filterService.guitarFilter[guitarTypeName].sorting = { ...this.filterUpdateService.filter.sorting };
    }
    
    private initVendorList(guitarTypeName: string): ng.IPromise<void> {
        this.filterUpdateService.filter.vendors = [];

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

    private refreshVendorListForClassicalGuitars() {
        return this.service.getClassicalGuitarVendors().then(vendors => {
            this.filterUpdateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }

    private refreshVendorListForWesternGuitars() {
        return this.service.getWesternGuitarVendors().then(vendors => {
            this.filterUpdateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }

    private refreshVendorListForElectricGuitars() {
        return this.service.getElectricGuitarVendors().then(vendors => {
            this.filterUpdateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }

    private refreshVendorListForBassGuitars() {
        return this.service.getBassGuitarVendors().then(vendors => {
            this.filterUpdateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }
}