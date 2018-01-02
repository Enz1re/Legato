import {
    Price,
    Vendor,
    Sorting
} from "../../../Models/models";

import {
    IUserService,
    IClaimService,
    IModalService,
    IFilterService,
    IVendorService,
    IUpdateService,
    IRoutingService,
} from "../../../Interfaces/interfaces";

import { Constants } from "../../../Constants";


export class MainController implements ng.IController {
    error = false;
    static $inject = ["$scope", "RoutingService", "UpdateService", "FilterService", "VendorService", "UserService", "ClaimService"];

    constructor(private $scope: ng.IScope, private routingService: IRoutingService, private updateService: IUpdateService, private filterService: IFilterService,
                private service: IVendorService, private userService: IUserService, private claimService: IClaimService) {
        const name = routingService.urlSegments[1];
        this.initVendorList(name).then(() => {
            this.activeTab = name;
            const urlParamResolver = routingService.getParamResolver();
            this.updateService.filter.price = urlParamResolver.resolvePrice();
            this.updateService.filter.sorting = urlParamResolver.resolveSorting();
            this.updateService.filter.vendors = urlParamResolver.resolveVendors(this.updateService.filter.vendors);
            this.updateService.filter.search = urlParamResolver.resolveSearchString();
        });
    }

    
}