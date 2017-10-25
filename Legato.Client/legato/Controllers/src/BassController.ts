import Price from '../../Models/Price';
import BassGuitar from '../../Models/BassGuitar';

import { IHttpService } from '../../Interfaces/interfaces';


export default class BassController implements ng.IController {
    private guitars: BassGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    private error = false;
    private $$cache: ng.ICacheObject;
    static $inject = ["$scope", "$cacheFactory", "HttpService"];

    constructor($scope: ng.IScope, $cacheFactory: ng.ICacheFactoryService, private http: IHttpService) {
        this.$$cache = $cacheFactory('bass');
        let cachedGuitars = this.$$cache.get<BassGuitar[]>('guitars');

        if (cachedGuitars) {
            this.guitars = cachedGuitars;
        } else {
            this.http.getAllBassGuitars().then(guitars => {
                this.guitars = guitars;
                this.$$cache.put('guitars', this.guitars);
            }).catch(err => {
                this.error = true;
            });
        }

        $scope.$on('bass', (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sortBy = params.sortBy;
            this.sortDirection = params.sortDirection;
        });
    }
}