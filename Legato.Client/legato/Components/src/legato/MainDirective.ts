export class MainDirective implements ng.IDirective {
    restrict = "E";
    controller = "MainController";
    controllerAs = "mainCtrl";
    templateUrl = "legato/Components/src/legato/main.html";
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = () => new MainDirective();
        return directive;
    }
}