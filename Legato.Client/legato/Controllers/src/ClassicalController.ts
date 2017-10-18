import Price from '../../Models/Price';
import ClassicalGuitar from '../../Models/ClassicalGuitar';
import { HttpService } from '../../Services/services-module';


export default class ClassicalController implements ng.IController {
    private guitars: ClassicalGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    static $inject = ["$scope", "HttpService"];

    constructor($scope: ng.IScope, private http: HttpService) {
        this.http.getAllClassicalGuitars().then(guitars => {
            this.guitars = guitars;
        });

        $scope.$on('classical', (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sortBy = params.sortBy;
            this.sortDirection = params.sortDirection
        });
    }
}