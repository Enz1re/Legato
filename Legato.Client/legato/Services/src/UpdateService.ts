import angular from "angular";

import {
    Price,
    Vendor,
    Sorting
} from "../../Models/models";

import { IUpdateService, IRoutingService } from "../../Interfaces/interfaces";


export default class UpdateService implements IUpdateService {
    update: boolean = true;
    filter: { price: Price, vendors: Vendor[], sorting: Sorting, search: string };
    static $inject = ["RoutingService"];

    constructor(private routingService: IRoutingService) {
        this.filter = {
            price: new Price(),
            vendors: [],
            sorting: new Sorting(),
            search: ""
        };
    }

    replacePriceQueryParams(stateName: string) {
        let queryParams = this.routingService.queryParams;

        queryParams.from = this.filter.price.from;
        queryParams.to = this.filter.price.to;

        this.routingService.redirect(stateName, queryParams);
    }

    replaceVendorQueryParams(stateName: string) {
        const checkedVendors = this.getCheckedVendors();
        let queryParams = this.routingService.queryParams;

        if (checkedVendors.length === this.filter.vendors.length) {
            queryParams.vendors = null;
        } else if (checkedVendors.length === 0) {
            queryParams.vendors = "\"\"";
        } else {
            queryParams.vendors = checkedVendors.join();
        }
        
        this.routingService.replace(stateName, queryParams);
    }    

    replaceSearchQueryParams(stateName: string) {
        let queryParams = this.routingService.queryParams;
        queryParams.search = this.filter.search;
        this.routingService.replace(stateName, queryParams);
    }

    replaceSortingQueryParams(stateName: string) {
        let queryParams = this.routingService.queryParams;

        if (this.filter.sorting.required) {
            queryParams.name = this.filter.sorting.name;
            // if sorting header is not Price, we don't need sort direction
            if (queryParams.name.toLowerCase() === 'price') {
                queryParams.direction = this.filter.sorting.direction;
            } else {
                queryParams.direction = null;
            }
        } else {
            queryParams.name = null;
            queryParams.direction = null;
        }

        this.routingService.replace(stateName, queryParams);
    }

    needUsePriceFilter(newValue, oldValue) {
        return (newValue.price.from !== oldValue.price.from || newValue.price.to !== oldValue.price.to) && newValue.price.from <= newValue.price.to;
    }

    needUseVendorFilter(newValue, oldValue) {
        return newValue.vendors.length > 0 && oldValue.vendors.length > 0 &&
            angular.toJson(newValue.vendors.filter(v => v.isSelected)) !== angular.toJson(oldValue.vendors.filter(v => v.isSelected))
    }

    needSearch(newValue, oldValue) {
        return newValue.search !== oldValue.search;
    }

    needUseSorting(newValue, oldValue) {
        return newValue.sorting.name !== oldValue.sorting.name ||
            newValue.sorting.direction !== oldValue.sorting.direction ||
            newValue.sorting.required !== oldValue.sorting.required;
    }

    updateData() {
        this.update = !this.update;
    }

    private getCheckedVendors() {
        let vendors = [];

        for (let v of this.filter.vendors) {
            if (v.isSelected) {
                vendors.push(v.name);
            }
        }

        return vendors;
    }
}