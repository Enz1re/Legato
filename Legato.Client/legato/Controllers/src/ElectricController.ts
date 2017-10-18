import Price from '../../Models/Price';
import ElectricGuitar from '../../Models/ElectricGuitar';
import { HttpService } from '../../Services/services-module';


export default class ElectricController implements ng.IController {
    private guitars: ElectricGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    static $inject = ["$scope", "HttpService"];

    constructor($scope: ng.IScope, private http: HttpService) {
        this.http.getAllElectricGuitars().then(guitars => {
            this.guitars = guitars;
        });

        $scope.$on('electric', (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sortBy = params.sortBy;
            this.sortDirection = params.sortDirection;
        });
    }
}