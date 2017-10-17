import { ClassicalController } from '../../../Controllers/controllers-module';


export default function classicalDirective(): ng.IDirective {
    return {
        restrict: 'E',
        controller: ClassicalController,
        controllerAs: 'classicalCtrl',
        templateUrl: 'legato/Directives/src/classical/classical.html',
        scope: {},
    }
}