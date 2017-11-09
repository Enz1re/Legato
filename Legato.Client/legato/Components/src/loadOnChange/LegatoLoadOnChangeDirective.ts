import { ILoadOnChangeService } from "../../../Interfaces/interfaces";

import { MainController } from "../../../Components/src/legato/MainController";

import angular from 'angular';


export class LegatoLoadOnChangeDirective implements ng.IDirective {
    restrict = "A";
    controller = "MainController";
    controllerAs = "mainCtrl";

    constructor(private onChangeService: ILoadOnChangeService) {

    }

    link(scope: ng.IScope, element: JQLite, attrs: ng.IAttributes, mainCtrl: MainController) {
        // check if the element is a form to invoke validity check in future
        const isForm = element.prop("tagName") === "FORM";

        element.find("input").on("input", e => {
            this.onChangeService.cancelPendingTask();

            if (!isForm || (isForm && element.hasClass("ng-invalid"))) {
                this.onChangeService.setPendingTask(mainCtrl.broadcastRequestEvent.bind(mainCtrl));
            }
        });

        element.find("select").on("change", e => {
            this.onChangeService.cancelPendingTask();
            this.onChangeService.setPendingTask(mainCtrl.broadcastRequestEvent.bind(mainCtrl));
        });
    }

    static create() {
        const directive: ng.IDirectiveFactory = (onChangeService: ILoadOnChangeService) => new LegatoLoadOnChangeDirective(onChangeService);
        directive.$inject = ["LoadOnChangeService"];
        return directive;
    }
}