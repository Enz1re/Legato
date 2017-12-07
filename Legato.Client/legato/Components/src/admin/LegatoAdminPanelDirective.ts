export class LegatoAdminPanelDirective implements ng.IDirective {
    restrict = "E";
    templateUrl = "legato/Components/src/admin/admin.html"
    controller = "AdminPanelController";
    controllerAs = "adminCtrl";
    bindToController = true;
    scope = {
        paging: "@"
    };

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = () => new LegatoAdminPanelDirective();
        return directive;
    }
}