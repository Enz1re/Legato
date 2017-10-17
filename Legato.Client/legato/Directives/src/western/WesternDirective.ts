import { WesternController } from '../../../Controllers/controllers-module';


export default function westernDirective(): ng.IDirective {
    return {
        restrict: 'E',
        controller: WesternController,
        controllerAs: 'westernCtrl',
        templateUrl: 'legato/Directives/src/western/western.html',
        scope: {},
    }
}