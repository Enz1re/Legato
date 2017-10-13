import { MainController } from '../controllers-module';
import ClassicalGuitar from '../../Models/ClassicalGuitar';
import { HttpService } from '../../Services/services-module';


export default class ClassicalController implements ng.IController {
    guitars: ClassicalGuitar[];
    static $inject = ["$scope", "HttpService"];

    constructor(private $scope: ng.IScope, private http: HttpService) {
        this.http.getAllClassicalGuitars().then(guitars => {
            this.guitars = guitars;
        });

        $scope.$on('click', (e, params) => {
            this.guitars = this.getByCost(params[0].from, params[0].to);
            this.guitars = this.getGuitarsWithVendors(params[1]);
        });
    }

    private getByCost(from: number, to: number) {
        if (from && to) {
            return this.guitars.filter(guitar => from <= guitar.StockPrice && guitar.StockPrice <= to);
        } else {
            return this.guitars;
        }
    }

    private getGuitarsWithVendors(vendors: string[]) {
        return this.guitars.filter(guitar => vendors.indexOf(guitar.Vendor) !== -1);
    }
}