import angular from "angular";


export class LegatoLoadOnScrollDirective implements ng.IDirective {
    restrict = "A";

    link(scope: ng.IScope, elem: JQLite, attrs: ng.IAttributes) {
        const scrollOffset = 20;
        const controller = scope.$eval(attrs.scrollController) || {};
        const callback = scope.$eval(attrs.scrollCallback).bind(controller) || (() => { });

        elem.on("scroll", (e: JQueryEventObject) => {
            const shouldScroll = scope.$eval(attrs.scrollIf || "true");
            if (e.target.scrollTop >= (e.target.scrollHeight - (e.target.clientHeight + scrollOffset)) && shouldScroll) {
                callback();
            }
        });
    }

    static create(): ng.IDirectiveFactory {
        const directive = () => new LegatoLoadOnScrollDirective();
        return directive;
    }
}