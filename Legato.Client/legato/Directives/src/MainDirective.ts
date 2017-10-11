import { MainController } from '../../Controllers/controllers-module';

export default function mainDirective(): ng.IDirective {
    return {
        restrict: 'E',
        controller: MainController,
        controllerAs: 'mainCtrl',
        templateUrl: 'legato/Templates/main.html',
        scope: {},
    }
}