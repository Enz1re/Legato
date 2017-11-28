export class LoginDirective implements ng.IDirective {
    restrict = "E";
    templateUrl = "legato/Components/login/login.html";
    bindings = {
        resolve: "<",
        close: "&",
        dismiss: "&"
    };
    controller = "LoginController";
    controllerAs = "loginCtrl";
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = () => new LoginDirective();
        return directive;
    }
}