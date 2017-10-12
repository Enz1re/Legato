import ElectroGuitar from '../../Models/ElectroGuitar';
import { HttpService } from '../../Services/services-module';


export default class ElectroController implements ng.IController {
    guitars: ElectroGuitar[];
    static $inject = ["$scope", "HttpService"];

    constructor(private $scope: ng.IScope, private http: HttpService) {
        this.http.getAllElectroGuitars().then(guitars => {
            this.guitars = guitars;
        });
    }
}