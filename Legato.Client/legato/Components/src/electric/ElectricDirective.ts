export class ElectricDirective implements ng.IDirective {
    restrict = "E";
    controller = "ElectricController";
    controllerAs = "electricCtrl";
    templateUrl = "legato/Components/src/electric/electric.html";
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = () => new ElectricDirective();
        return directive;
    }
}