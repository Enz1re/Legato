import { MainController } from '../../../Controllers/controllers-module';


export default function mainDirective(): ng.IDirective {
    return {
        restrict: 'E',
        controller: MainController,
        controllerAs: 'mainCtrl',
        templateUrl: 'legato/Directives/src/legato/main.html',
        scope: {},
    }
}