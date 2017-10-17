import { BassController } from '../../../Controllers/controllers-module';


export default function bassDirective(): ng.IDirective {
    return {
        restrict: 'E',
        controller: BassController,
        controllerAs: 'bassCtrl',
        templateUrl: 'legato/Directives/src/bass/bass.html',
        scope: {},
    }
}