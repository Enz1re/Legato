export class ClassicalDirective implements ng.IDirective {
    restrict = "E";
    controller = "ClassicalController";
    controllerAs = "classicalCtrl";
    templateUrl = "legato/Components/src/classical/classical.html";
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = () => new ClassicalDirective();
        return directive;
    }
}