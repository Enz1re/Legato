import { ElectricController } from '../../../Controllers/controllers-module';


export default function electricDirective(): ng.IDirective {
    return {
        restrict: 'E',
        controller: ElectricController,
        controllerAs: 'electricCtrl',
        templateUrl: 'legato/Directives/src/electric/electric.html',
        scope: {},
    }
}