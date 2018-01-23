import angular from "angular";
import { FilterPanelController } from "./FilterPanelController";

import { IUpdateService } from "../../../Interfaces/interfaces";


describe("FilterPanelController", () => {
    let updateService: IUpdateService;
    let controller: FilterPanelController;

    beforeEach(() => {
        updateService = <IUpdateService>{
            filter: { price: null, vendors: [], sorting: null, search: "" },
            updatePage: { updateCurrentPage: false, updateLastPage: false },
            replacePriceQueryParams: jasmine.createSpy("replacePriceQueryParams"),
            replaceVendorQueryParams: jasmine.createSpy("replaceVendorQueryParams"),
            replaceSearchQueryParams: jasmine.createSpy("replaceSearchQueryParams"),
            replaceSortingQueryParams: jasmine.createSpy("replaceSortingQueryParams"),
            needUsePriceFilter: jasmine.createSpy("needUsePriceFilter"),
            needUseVendorFilter: jasmine.createSpy("needUseVendorFilter"),
            needSearch: jasmine.createSpy("needSearch"),
            needUseSorting: jasmine.createSpy("needUseSorting"),
            updateCurrentPage: jasmine.createSpy("updateCurrentPage"),
            updateLastPage: jasmine.createSpy("updateLastPage")
        };

        controller = new FilterPanelController(updateService);
    });

    it("does search if enter key is pressed", () => {
        controller.search = "Search string";
        controller.doSearch({ key: "eNtEr" });
        expect(updateService.filter.search).toBe("Search string");
    });

    it("doesn't do search if escape key is pressed", () => {
        controller.search = "Search string";
        controller.doSearch({ key: "esc" });
        expect(updateService.filter.search).not.toBe("Search string");
    });

    it("flushes filter of updateService", () => {
        controller.unfilter();
        expect(updateService.filter.search).toBe("");
        expect(updateService.filter.price.from).toBeNull();
        expect(updateService.filter.price.to).toBeNull();
        expect(angular.equals(updateService.filter.sorting, { required: false, name: null, direction: null }));
        expect(updateService.filter.vendors.every(v => v.isSelected));
    });
});