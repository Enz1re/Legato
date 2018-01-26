import {
    IUpdateService,
    IFilterStateService,
    IRoutingService
} from "../../../Interfaces/interfaces";

import { Price, Sorting } from "../../../Models/models";


export class TabPanelController {
    static $inject = ["UpdateService", "FilterStateService", "RoutingService"];
    activeTab: string;

    constructor(private updateService: IUpdateService, private filterService: IFilterStateService, private routingService: IRoutingService) {
        this.activeTab = routingService.urlSegments[1];
    }

    checkTab(click, guitarTypeName: string) {
        if (this.activeTab === guitarTypeName || click === undefined) {
            return;
        }

        this.activeTab = guitarTypeName;
        this.updateService.filter.price = this.filterService.guitarFilter[guitarTypeName].price || new Price();
        this.updateService.filter.sorting = this.filterService.guitarFilter[guitarTypeName].sorting || new Sorting();
        this.updateService.filter.search = this.filterService.guitarFilter[guitarTypeName].search;
        
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
}