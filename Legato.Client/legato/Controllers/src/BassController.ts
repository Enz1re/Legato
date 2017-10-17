import BassGuitar from '../../Models/BassGuitar';
import { HttpService } from '../../Services/services-module';


export default class BassController implements ng.IController {
    private guitars: BassGuitar[] = [];
    static $inject = ["$scope", "HttpService"];
    
    constructor($scope: ng.IScope, private http: HttpService) {
        this.http.getAllBassGuitars().then(guitars => {
            this.guitars = guitars;
        });
    }
}