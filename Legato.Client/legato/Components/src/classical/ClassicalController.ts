import Price from '../../../Models/Price';
import ClassicalGuitar from '../../../Models/ClassicalGuitar';

import { IHttpService } from '../../../Interfaces/interfaces';


export class ClassicalController implements ng.IController {
    private guitars: ClassicalGuitar[] = [];
    private price: Price;
    private vendors: string[];
    private sortBy: string;
    private sortDirection: string;
    private error = false;
    private $$cache: ng.ICacheObject;
    static $inject = ["$scope", "$cacheFactory", "HttpService"];

    constructor($scope: ng.IScope, $cacheFactory: ng.ICacheFactoryService, private http: IHttpService) {
        this.$$cache = $cacheFactory('classical');
        let cachedGuitars = this.$$cache.get<ClassicalGuitar[]>('guitars');

        if (cachedGuitars) {
            this.guitars = cachedGuitars;
        } else {
            this.http.getAllClassicalGuitars().then(guitars => {
                this.guitars = guitars;
                this.$$cache.put('guitars', this.guitars);
            }).catch(err => {
                this.error = true;
            });
        }

        $scope.$on('classical', (e, params) => {
            this.price = params.price;
            this.vendors = params.vendors;
            this.sortBy = params.sortBy;
            this.sortDirection = params.sortDirection
        });
    }
}