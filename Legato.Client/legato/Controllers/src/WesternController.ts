import WesternGuitar from '../../Models/WesternGuitar';
import { HttpService } from '../../Services/services-module';


export default class WesternController implements ng.IController {
    private guitars: WesternGuitar[] = [];
    static $inject = ["$scope", "HttpService"];

    constructor($scope: ng.IScope, private http: HttpService) {
        this.http.getAllWesternGuitars().then(guitars => {
            this.guitars = guitars;
        });
    }
}