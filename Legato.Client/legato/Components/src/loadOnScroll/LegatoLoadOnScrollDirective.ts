import angular from "angular";


export class LegatoLoadOnScrollDirective implements ng.IDirective {
    restrict = "A";

    link(scope: ng.IScope, elem: JQLite, attrs: ng.IAttributes, ctrl) {
        const scrollOffset = 20;
        const controller = scope.$eval(attrs.scrollController) || scope.$eval(this.findController(scope)) || {};
        const callback = scope.$eval(attrs.scrollCallback).bind(controller) || (() => { });

        elem.on("scroll", (e: JQueryEventObject) => {
            const shouldScroll = scope.$eval(attrs.scrollIf || "true");
            if (e.target.scrollTop >= (e.target.scrollHeight - (e.target.clientHeight + scrollOffset)) && shouldScroll) {
                callback();
            }
        });
    }

    private findController(scope: ng.IScope) {
        for (let member in scope) {
            if (scope.hasOwnProperty(member) && /Ctrl/.exec(member)) {
                return member;
            }
        }

        return "null";
    }

    static create(): ng.IDirectiveFactory {
        const directive = () => new LegatoLoadOnScrollDirective();
        return directive;
    }
}