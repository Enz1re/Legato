export class WesternDirective implements ng.IDirective {
    restrict = 'E';
    controller = 'WesternController';
    controllerAs = 'westernCtrl';
    templateUrl = 'legato/Directives/src/western/western.html';
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = () => new WesternDirective();
        return directive;
    }
}