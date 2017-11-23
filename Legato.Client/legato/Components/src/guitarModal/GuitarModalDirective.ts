export class GuitarModalDirective implements ng.IDirective {
    restrict = "E";
    controller = "GuitarModalController";
    controllerAs = "modalCtrl";
    templateUrl = "legato/Components/src/guitarModal/guitarModal.html";
    bindToController = {
        guitar: "="
    };
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = () => new GuitarModalDirective();
        return directive;
    }
}