export class LegatoSmoothScrollDirective implements ng.IDirective {
    restrict = "A";
    require = "ngModel";

    constructor(private $interval: ng.IIntervalService) {

    }

    link(scope: ng.IScope, element: JQLite, attrs: ng.IAttributes) {
        scope.$watch(attrs.ngModel, () => {
            let index = 1;
            let top = document.documentElement.scrollTop;
            this.$interval(() => {
                if (index * 100 <= 3000) {
                    document.documentElement.scrollTop = top - top / 30 * index++;
                }
            }, 10);
        });
    }

    static create() {
        const directive: ng.IDirectiveFactory = ($interval: ng.IIntervalService) => new LegatoSmoothScrollDirective($interval);
        directive.$inject = ["$interval"];
        return directive;
    }
}