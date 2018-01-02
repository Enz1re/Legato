import { TopPanelController } from "./TopPanelController";


export class LegatoTopPanelDirective implements ng.IDirective {
    restrict = "E";
    controller = TopPanelController;
    controllerAs = "topPanelCtrl";
    templateUrl = "legato/Components/src/topPanel/topPanel.html";
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive = () => new LegatoTopPanelDirective();
        return directive;
    }
}