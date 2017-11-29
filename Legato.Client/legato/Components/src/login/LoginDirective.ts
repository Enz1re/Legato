export class LoginDirective implements ng.IDirective {
    restrict = "E";
    templateUrl = "legato/Components/login/login.html";
    controller = "LoginController";
    controllerAs = "loginCtrl";
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = () => new LoginDirective();
        return directive;
    }
}