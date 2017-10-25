export class LegatoValidatePriceDirective implements ng.IDirective {
    restrict = 'A';
    require = 'ngModel';

    link(scope, element, attrs, controller: ng.INgModelController) {
        scope.$watch(attrs.ngModel, (price: any) => {
            if (price.from > price.to) {
                controller.$setValidity('validate-price', false);
            } else {
                controller.$setValidity('validate-price', true);
            }
        }, true);
    }

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = () => new LegatoValidatePriceDirective();
        return directive;
    }
}