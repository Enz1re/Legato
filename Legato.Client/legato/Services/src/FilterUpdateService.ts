import {
    Price,
    Vendor,
    Sorting
} from "../../Models/models";

import { IFilterUpdateService, IRoutingService } from "../../Interfaces/interfaces";


export default class FilterUpdateService implements IFilterUpdateService {
    filter: { price: Price, vendors: Vendor[], sorting: Sorting };
    static $inject = ["RoutingService"];

    constructor(private routingService: IRoutingService) {
        this.filter = {
            price: new Price(),
            vendors: [],
            sorting: new Sorting()
        };
    }

    replacePriceQueryParams(stateName: string) {
        let queryParams = this.routingService.queryParams();

        queryParams.from = this.filter.price.from;
        queryParams.to = this.filter.price.to;

        this.routingService.redirect(stateName, queryParams);
    }

    replaceVendorQueryParams(stateName: string) {
        const checkedVendors = this.getCheckedVendors();
        let queryParams = this.routingService.queryParams();

        if (checkedVendors.length === this.filter.vendors.length) {
            queryParams.vendors = null;
        } else if (checkedVendors.length === 0) {
            queryParams.vendors = "\"\"";
        } else {
            queryParams.vendors = checkedVendors.join();
        }

        this.routingService.replace(stateName, queryParams);
    }

    replaceSortingQueryParams(stateName: string) {
        let queryParams = this.routingService.queryParams();

        if (this.filter.sorting.required) {
            queryParams.name = this.filter.sorting.name;
            // if sorting header is not Price, we don't need sort direction
            if (this.filter.sorting.name.toLowerCase() === 'price') {
                queryParams.direction = this.filter.sorting.direction;
            } else {
                queryParams.direction = null;
            }
        } else {
            queryParams.name = queryParams.direction = null;
        }

        this.routingService.replace(stateName, queryParams);
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