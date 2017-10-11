import ClassicalGuitar from '../../Models/ClassicalGuitar';
import { HttpService } from '../../Services/services-module';


export default class ClassicalController implements ng.IController {
    guitars: Array<ClassicalGuitar>;
    static $inject = ["$scope", "HttpService"];

    constructor(private $scope: ng.IScope, private http: HttpService) {
        this.http.getAllClassicalGuitars().then(guitars => {
            this.guitars = guitars;
        });
    }
}