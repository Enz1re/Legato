import Price from '../../Models/Price';
import WesternGuitar from '../../Models/WesternGuitar';

import { IHttpService } from '../../Interfaces/interfaces';


export default class WesternController implements ng.IController {
    private guitars: WesternGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    private error = false;
    private $$cache: ng.ICacheObject;
    static $inject = ["$scope", "$cacheFactory", "HttpService"];

    constructor($scope: ng.IScope, $cacheFactory: ng.ICacheFactoryService, private http: IHttpService) {
        this.$$cache = $cacheFactory('western');
        let cachedGuitars = this.$$cache.get<WesternGuitar[]>('guitars');

        if (cachedGuitars) {
            this.guitars = cachedGuitars;
        } else {
            this.http.getAllWesternGuitars().then(guitars => {
                this.guitars = guitars;
                this.$$cache.put('guitars', this.guitars);
            }).catch(err => {
                this.error = true;
            });
        }

        $scope.$on('western', (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sortBy = params.sortBy;
            this.sortDirection = params.sortDirection;
        });
    }
}