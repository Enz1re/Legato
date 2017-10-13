import { ElectricController } from '../../Controllers/controllers-module';

export default function electricDirective(): ng.IDirective {
    return {
        restrict: 'E',
        controller: ElectricController,
        controllerAs: 'electricCtrl',
        templateUrl: 'legato/Templates/electric.html',
        scope: {},
    }
}