import { FilterPanelController } from "./FilterPanelController";


export class LegatoFilterPanelDirective implements ng.IDirective {
    restrict = "E";
    controller = FilterPanelController;
    controllerAs = "filterCtrl";
    templateUrl = "legato/Components/src/filterPanel/filterPanel.html";
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive = () => new LegatoFilterPanelDirective();
        return directive;
    }
}