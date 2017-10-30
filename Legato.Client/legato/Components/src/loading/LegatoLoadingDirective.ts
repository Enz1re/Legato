export class LegatoLoadingDirective implements ng.IDirective {
    restrict = "C";

    constructor(private $animate: ng.animate.IAnimateService) {
        
    }

    link(scope, elem, attrs) {
        this.$animate.leave(elem.children().eq(1)).then(() => {
            elem.remove();
            scope = elem = attrs = null;
        });
    }

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = ($animate: ng.animate.IAnimateService) => new LegatoLoadingDirective($animate);
        directive.$inject = ["$animate"];
        return directive;
    }
}