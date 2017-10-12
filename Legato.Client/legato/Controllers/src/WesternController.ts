import WesternGuitar from '../../Models/WesternGuitar';
import { HttpService } from '../../Services/services-module';


export default class WesternController implements ng.IController {
    guitars: WesternGuitar[];
    static $inject = ["$scope", "HttpService"];

    constructor(private $scope: ng.IScope, private http: HttpService) {
        this.http.getAllWesternGuitars().then(guitars => {
            this.guitars = guitars;
        });
    }
}