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
    vendors: Vendor[] = [];
    error = false;
    activeTab: string;
    price: Price = new Price();
    sorting: Sorting = new Sorting();
    static $inject = ["RoutingService", "FilterUpdateService", "FilterService", "VendorService"];

    constructor(private routingService: IRoutingService, private filterUpdateService: IFilterUpdateService,
                private filterService: IFilterService, private service: IVendorService) {
        const name = routingService.urlSegments[1];
        const urlParamResolver = routingService.getParamResolver();
        
        this.price = this.filterUpdateService.filter.price = urlParamResolver.resolvePrice();
        this.sorting = this.filterUpdateService.filter.sorting = urlParamResolver.resolveSorting();

        this.activeTab = name;
        
        this.initVendorList(name).then(() => {
            this.vendors = this.filterUpdateService.filter.vendors = urlParamResolver.resolveVendors(this.vendors);
        });
    }

    refreshVendorList(click, guitarTypeName: string) {
        if (this.activeTab === guitarTypeName || click === undefined) {
            return;
        }
        
        this.price = this.filterService.guitarFilter[guitarTypeName].price || new Price();
        this.vendors = this.filterService.guitarFilter[guitarTypeName].vendors || this.vendors;
        this.sorting = this.filterService.guitarFilter[guitarTypeName].sorting || new Sorting();

        this.initVendorList(guitarTypeName);

        this.routingService.redirect(this.activeTab, this.filterService.guitarFilter[guitarTypeName]);
    }

    onTabDeselected(guitarTypeName: string) {
        this.filterService.guitarFilter[guitarTypeName] = this.routingService.queryParams;
        console.log(this.filterService.guitarFilter[guitarTypeName]);
    }

    onPriceChanged() {
        this.filterUpdateService.filter.price = this.price;
    }

    onVendorsChanged() {
        this.filterUpdateService.filter.vendors = this.vendors;
    }

    onSortingChanged() {
        this.filterUpdateService.filter.sorting = this.sorting;
    }

    private initVendorList(guitarTypeName: string): ng.IPromise<void> {
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