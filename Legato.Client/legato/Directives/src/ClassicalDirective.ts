import { ClassicalController } from '../../Controllers/controllers-module';

export default function classicalDirective(): ng.IDirective {
    return {
        restrict: 'E',
        controller: ClassicalController,
        controllerAs: 'classicalCtrl',
        templateUrl: 'legato/Templates/classical.html',
        scope: {},
    }
}