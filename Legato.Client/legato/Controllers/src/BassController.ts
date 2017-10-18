import Price from '../../Models/Price';
import BassGuitar from '../../Models/BassGuitar';
import { HttpService } from '../../Services/services-module';


export default class BassController implements ng.IController {
    private guitars: BassGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    static $inject = ["$scope", "HttpService"];
    
    constructor($scope: ng.IScope, private http: HttpService) {
        this.http.getAllBassGuitars().then(guitars => {
            this.guitars = guitars;
        });

        $scope.$on('bass', (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sortBy = params.sortBy;
            this.sortDirection = params.sortDirection;
        });
    }
}