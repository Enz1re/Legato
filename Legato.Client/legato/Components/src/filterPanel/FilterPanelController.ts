import { IUpdateService, IVendorService } from "../../../Interfaces/interfaces";


export class FilterPanelController {
    search: string;
    static $inject = ["UpdateService", "VendorService"];

    constructor(private updateService: IUpdateService) {

    }

    doSearch(event) {
        if (event.key.toLowerCase() === "enter") {
            this.updateService.filter.search = this.search;
        }
    }

    unfilter() {
        this.updateService.filter.search = "";
        this.updateService.filter.price = { from: null, to: null };
        this.updateService.filter.sorting = {
            required: false,
            name: null,
            direction: null
        };
        this.updateService.filter.vendors.forEach(v => {
            v.isSelected = true;
        });
    }
}