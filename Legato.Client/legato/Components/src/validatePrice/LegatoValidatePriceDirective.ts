export class LegatoValidatePriceDirective implements ng.IDirective {
    restrict = "A";
    require = "ngModel";

    link(scope: ng.IScope, element, attrs, controller: ng.INgModelController) {
        scope.$watch(attrs.ngModel, (price: any, oldValue: any, scope) => {
            // if value becomes undefined, than it doesn't meet the max-length validation
            // if so, turn it back to its previous value, which has met this requirement
            if (price.from === undefined) {
                price.from = oldValue.from;
            }
            if (price.to === undefined) {
                price.to = oldValue.to;
            }
            // From value must be less or equal than To value
            if (price.from > price.to) {
                controller.$setValidity("greater", false);
            } else {
                controller.$setValidity("greater", true);
            }
        }, true);
    }

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = () => new LegatoValidatePriceDirective();
        return directive;
    }
}