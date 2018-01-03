import { PaginationController } from "./PaginationController";


export class LegatoPaginationDirective implements ng.IDirective {
    restrict = "E";
    controller = PaginationController;
    controllerAs = "paginationCtrl";
    templateUrl = "legato/Components/src/legatoPagination/legatoPagination.html";

    static create() {
        const directive = () => new LegatoPaginationDirective();
        return directive;
    }
}