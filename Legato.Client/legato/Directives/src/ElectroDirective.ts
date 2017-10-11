import { ElectroController } from '../../Controllers/controllers-module';

export default function electroDirective(): ng.IDirective {
    return {
        restrict: 'E',
        controller: ElectroController,
        controllerAs: 'electroCtrl',
        templateUrl: 'legato/Templates/electro.html',
        scope: {},
    }
}