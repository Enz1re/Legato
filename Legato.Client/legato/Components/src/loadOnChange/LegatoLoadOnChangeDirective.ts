import { IPendingTaskService } from "../../../Interfaces/interfaces";

import { MainController } from "../../../Components/src/legato/MainController";

import angular from 'angular';


export class LegatoLoadOnChangeDirective implements ng.IDirective {
    restrict = "A";
    controller = "MainController";
    controllerAs = "mainCtrl";
    private inputTextFieldTypes = [
        "text", "password", "email", "number", "url", "search"
    ];
    private inputBoxTypes = [
        "checkbox", "radio"
    ];

    constructor(private onChangeService: IPendingTaskService) {

    }

    link(scope: ng.IScope, element: JQLite, attrs: ng.IAttributes, mainCtrl: MainController) {
        // check if the element is a form to invoke validity check in future
        const isForm = element.prop("tagName") === "FORM";
        const formName = isForm ? element.prop("name") : null;

        this.getInputTextFields(element).forEach(obj => {
            obj.on("input", e => {
                this.onChangeService.cancelPendingTask();
                
                if (!isForm || (isForm && scope[formName].$valid)) {
                    this.onChangeService.setPendingTask(mainCtrl.broadcastRequestEvent.bind(mainCtrl));
                }
            });
        });

        this.getInputBoxFields(element).forEach(obj => {
            obj.on("change", e => {
                this.onChangeService.cancelPendingTask();
                
                if (!isForm || (isForm && scope[formName].$valid)) {
                    this.onChangeService.setPendingTask(mainCtrl.broadcastRequestEvent.bind(mainCtrl));
                }
            });
        });

        element.find("select").on("change", e => {
            this.onChangeService.cancelPendingTask();
            this.onChangeService.setPendingTask(mainCtrl.broadcastRequestEvent.bind(mainCtrl));
        });
    }

    static create() {
        const directive: ng.IDirectiveFactory = (onChangeService: IPendingTaskService) => new LegatoLoadOnChangeDirective(onChangeService);
        directive.$inject = ["PendingTaskService"];
        return directive;
    }

    private getInputTextFields(container: JQLite) {
        const allInputs = container.find("input");
        let filtered = [];
        
        angular.forEach(allInputs, (value, key) => {
            const jqueryObj = angular.element(value);
            if (this.isTextField(jqueryObj)) {
                filtered.push(jqueryObj);
            }
        });
        
        return filtered;
    }

    private getInputBoxFields(container: JQLite) {
        const allInputs = container.find("input");
        let filtered = [];
        
        angular.forEach(allInputs, (value, key) => {
            const jqueryObj = angular.element(value);
            if (this.isBoxField(jqueryObj)) {
                filtered.push(jqueryObj);
            }
        });
        
        return filtered;
    }

    private isTextField(input: JQLite) {
        return this.inputTextFieldTypes.indexOf(input.attr("type")) !== -1;
    }

    private isBoxField(input: JQLite) {
        return this.inputBoxTypes.indexOf(input.attr("type")) !== -1;
    }
}