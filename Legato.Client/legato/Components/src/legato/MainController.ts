import {
    IClaimService,
    IUpdateService,
    IRoutingService,
} from "../../../Interfaces/interfaces";


export class MainController implements ng.IController {
    static $inject = ["RoutingService", "UpdateService", "ClaimService"];

    constructor(private routingService: IRoutingService, private updateService: IUpdateService, private claimService: IClaimService) {
        const urlParamResolver = routingService.getParamResolver();
        this.updateService.filter.price = urlParamResolver.resolvePrice();
        this.updateService.filter.sorting = urlParamResolver.resolveSorting();
        this.updateService.filter.vendors = urlParamResolver.resolveVendors(this.updateService.filter.vendors);
        this.updateService.filter.search = urlParamResolver.resolveSearchString();
    }
}