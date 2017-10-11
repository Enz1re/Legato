import { HttpService } from '../../Services/services-module';


export default class MainController implements ng.IController {
    static $inject = ["$scope", "HttpService"];

    constructor (private $scope: ng.IScope, private http: HttpService) {
        
    }
}