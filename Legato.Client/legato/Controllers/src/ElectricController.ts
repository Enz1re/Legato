import ElectricGuitar from '../../Models/ElectricGuitar';
import { HttpService } from '../../Services/services-module';


export default class ElectricController implements ng.IController {
    guitars: ElectricGuitar[];
    static $inject = ["$scope", "HttpService"];

    constructor(private $scope: ng.IScope, private http: HttpService) {
        this.http.getAllElectricGuitars().then(guitars => {
            this.guitars = guitars;
        });
    }
}