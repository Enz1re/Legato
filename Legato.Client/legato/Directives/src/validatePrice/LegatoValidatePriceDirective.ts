export default function validatePriceDirective(): ng.IDirective {
    return {
        restrict: 'A',
        link: (scope, element, attrs, controller: ng.INgModelController) => {
            scope.$watch(attrs.ngModel, (price: any) => {
                if (price.from > price.to) {
                    controller.$setValidity('validate-price', false);
                } else {
                    controller.$setValidity('validate-price', true);
                }
            }, true);
        }
    }
}