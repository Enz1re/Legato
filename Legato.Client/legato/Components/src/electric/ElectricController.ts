import Price from '../../../Models/Price';
import ElectricGuitar from '../../../Models/ElectricGuitar';

import { IHttpService } from '../../../Interfaces/interfaces';


export class ElectricController implements ng.IController {
    private guitars: ElectricGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    private error = false;
    private $$cache: ng.ICacheObject;
    static $inject = ["$scope", "$cacheFactory", "HttpService"];

    constructor($scope: ng.IScope, $cacheFactory: ng.ICacheFactoryService, private http: IHttpService) {
        this.$$cache = $cacheFactory('electric');
        let cachedGuitars = this.$$cache.get<ElectricGuitar[]>('guitars');

        if (cachedGuitars) {
            this.guitars = cachedGuitars;
        } else {
            this.http.getAllElectricGuitars().then(guitars => {
                this.guitars = guitars;
                this.$$cache.put('guitars', this.guitars);
            }).catch(err => {
                this.error = true;
            });
        }

        $scope.$on('electric', (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sortBy = params.sortBy;
            this.sortDirection = params.sortDirection;
        });
    }
}