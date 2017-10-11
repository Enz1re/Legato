import { WesternController } from '../../Controllers/controllers-module';

export default function westernDirective(): ng.IDirective {
    return {
        restrict: 'E',
        controller: WesternController,
        controllerAs: 'westernCtrl',
        templateUrl: 'legato/Templates/western.html',
        scope: {},
    }
}