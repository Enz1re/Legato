import { Price, Sorting, Vendor } from "../../Models/models";

import { IUrlParamResolver } from "../../Interfaces/interfaces";


export default class UrlParamResolver implements IUrlParamResolver {
    private stateParamsObject: ng.ui.IStateParamsService;

    constructor(stateParamsObject: ng.ui.IStateParamsService) {
        this.stateParamsObject = stateParamsObject;
    }

    resolvePage() {
        if (!this.stateParamsObject.page) {
            return 1;
        }

        const parsedPage = parseInt(this.stateParamsObject.page);

        return parsedPage ? parsedPage : 1;
    }

    resolvePrice() {
        if (!this.stateParamsObject.from || !this.stateParamsObject.to) {
            return new Price();
        }

        const parsedFrom = parseInt(this.stateParamsObject.from);
        const parsedTo = parseInt(this.stateParamsObject.to);

        return parsedFrom && parsedTo ? new Price({ from: parsedFrom, to: parsedTo }) : new Price();
    }

    resolveVendors(vendorList: Vendor[] = null) {
        if (!this.stateParamsObject.vendors) {
            return vendorList;
        }

        const checkedVendors = this.stateParamsObject.vendors !== "" ? this.stringToVendorArray(this.stateParamsObject.vendors) : [];

        return vendorList ? this.uncheckVendors(vendorList, checkedVendors) : checkedVendors;
    }

    resolveSorting() {
        if (!this.stateParamsObject.name || !this.stateParamsObject.direction) {
            return new Sorting();
        }

        return new Sorting({
            required: true,
            name: this.stateParamsObject.name,
            direction: this.stateParamsObject.direction
        });
    }

    resolveIndex() {
        if (!this.stateParamsObject.g) {
            return null;
        }

        const index = parseInt(this.stateParamsObject.g);

        return index ? index : null;
    }

    private uncheckVendors(allVendors: Vendor[], queriedVendors: Vendor[]) {
        allVendors.forEach(v => {
            v.isSelected = queriedVendors.map(qv => qv.name).indexOf(v.name) !== -1
        });

        return allVendors;
    }

    private stringToVendorArray(vendors: string | string[]) {
        if (typeof vendors === "string") {
            vendors = vendors.split(",");
        }

        return vendors.map(v => new Vendor({ name: v, isSelected: true }));
    }
}