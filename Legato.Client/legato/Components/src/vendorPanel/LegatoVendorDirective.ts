import { VendorController } from "./VendorController";


export class LegatoVendorDirective implements ng.IDirective {
    restrict = "E";
    controller = VendorController;
    controllerAs = "vendorCtrl";
    templateUrl = "legato/Components/src/vendorPanel/vendorPanel.html";
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive = () => new LegatoVendorDirective();
        return directive;
    }
}