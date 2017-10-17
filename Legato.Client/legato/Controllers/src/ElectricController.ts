import ElectricGuitar from '../../Models/ElectricGuitar';
import { HttpService } from '../../Services/services-module';


export default class ElectricController implements ng.IController {
    private guitars: ElectricGuitar[] = [];
    static $inject = ["$scope", "HttpService"];

    constructor($scope: ng.IScope, private http: HttpService) {
        this.http.getAllElectricGuitars().then(guitars => {
            this.guitars = guitars;
        });
    }
}