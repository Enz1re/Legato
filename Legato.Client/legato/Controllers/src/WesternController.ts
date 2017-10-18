import Price from '../../Models/Price';
import WesternGuitar from '../../Models/WesternGuitar';
import { HttpService } from '../../Services/services-module';


export default class WesternController implements ng.IController {
    private guitars: WesternGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    static $inject = ["$scope", "HttpService"];

    constructor($scope: ng.IScope, private http: HttpService) {
        this.http.getAllWesternGuitars().then(guitars => {
            this.guitars = guitars;
        });

        $scope.$on('western', (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sortBy = params.sortBy;
            this.sortDirection = params.sortDirection;
        });
    }
}