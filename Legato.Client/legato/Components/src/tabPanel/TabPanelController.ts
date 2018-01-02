import {
    IUpdateService,
    IFilterService,
    IRoutingService
} from "../../../Interfaces/interfaces";

import { Price, Sorting } from "../../../Models/models";


export class TabPanelController {
    activeTab: string;
    static $inject = ["UpdateService", "FilterService", "RoutingService"];

    constructor (private updateService: IUpdateService, private filterService: IFilterService, private routingService: IRoutingService) {

    }

    checkTab(click, guitarTypeName: string) {
        if (this.activeTab === guitarTypeName || click === undefined) {
            return;
        }

        this.activeTab = guitarTypeName;
        this.updateService.filter.price = this.filterService.guitarFilter[guitarTypeName].price || new Price();
        this.updateService.filter.sorting = this.filterService.guitarFilter[guitarTypeName].sorting || new Sorting();
        this.updateService.filter.search = this.filterService.guitarFilter[guitarTypeName].search;

        if (this.filterService.guitarFilter[guitarTypeName].vendors) {
            this.updateService.filter.vendors = this.filterService.guitarFilter[guitarTypeName].vendors;
        } else {
            this.initVendorList(guitarTypeName);
        }

        this.routingService.redirect(this.activeTab, this.filterService.guitarFilter[guitarTypeName].params || { page: "1" });
    }

    onTabDeselected(event, guitarTypeName: string) {
        if (event === undefined) {
            return;
        }

        this.filterService.guitarFilter[guitarTypeName].params = { ...this.routingService.queryParams };
        this.filterService.guitarFilter[guitarTypeName].price = { ...this.updateService.filter.price };
        this.filterService.guitarFilter[guitarTypeName].vendors = [...this.updateService.filter.vendors];
        this.filterService.guitarFilter[guitarTypeName].sorting = { ...this.updateService.filter.sorting };
        this.filterService.guitarFilter[guitarTypeName].search = this.updateService.filter.search;
    }

    // TODO: make a vendor panel and move this functionality to it
    private initVendorList(guitarTypeName: string): ng.IPromise<void> {
        this.updateService.filter.vendors = [];

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
            this.updateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }

    private refreshVendorListForWesternGuitars() {
        return this.service.getWesternGuitarVendors().then(vendors => {
            this.updateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }

    private refreshVendorListForElectricGuitars() {
        return this.service.getElectricGuitarVendors().then(vendors => {
            this.updateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }

    private refreshVendorListForBassGuitars() {
        return this.service.getBassGuitarVendors().then(vendors => {
            this.updateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }
}