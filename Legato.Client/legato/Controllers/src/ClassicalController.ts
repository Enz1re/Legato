import ClassicalGuitar from '../../Models/ClassicalGuitar';
import { HttpService } from '../../Services/services-module';


export default class ClassicalController implements ng.IController {
    private guitars: ClassicalGuitar[] = [];
    static $inject = ["$scope", "HttpService"];

    constructor($scope: ng.IScope, private http: HttpService) {
        this.http.getAllClassicalGuitars().then(guitars => {
            this.guitars = guitars;
        });
    }
}