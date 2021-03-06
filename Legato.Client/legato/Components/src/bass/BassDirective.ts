﻿export class BassDirective implements ng.IDirective {
    restrict = "E";
    controller = "BassController";
    controllerAs = "bassCtrl";
    templateUrl = "legato/Components/src/bass/bass.html";
    scope = {};

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = () => new BassDirective();
        return directive;
    }
}