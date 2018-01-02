import { TabPanelController } from "./TabPanelController";


export class LegatoTabPanelDirective implements ng.IDirective {
    restrict = "E";
    controller = TabPanelController;
    controllerAs = "tabPanelCtrl";
    templateUrl = "legato/Components/src/tabPanel/tabPanel.html";
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive = () => new LegatoTabPanelDirective();
        return directive;
    }
}