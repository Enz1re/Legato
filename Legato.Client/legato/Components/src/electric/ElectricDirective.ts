export class ElectricDirective implements ng.IDirective {
    restrict = "E";
    controller = "ElectricController";
    controllerAs = "electricCtrl";
    bindToController = {
        price: "=",
        vendors: "=",
        sorting: "="
    };
    templateUrl = "legato/Components/src/electric/electric.html";
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = () => new ElectricDirective();
        return directive;
    }
}