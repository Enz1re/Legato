import {
    IManageService,
    IPagingService,
    IRoutingService
} from "../../Interfaces/interfaces";


export default class PagingService implements IPagingService {
    private _itemsToShow: number;
    static $inject = ["ManageService", "RoutingService"];
    total: number;
    lowerBound: number;
    upperBound: number;
    currentPage: number;

    constructor(private manageService: IManageService, private routingService: IRoutingService) {
        manageService.getDisplayAmount().then(amount => {
            this.itemsToShow = amount;
            this.lowerBound = 0;
            this.upperBound = this.itemsToShow;
        });
    }

    get itemsToShow() {
        return this._itemsToShow;
    }

    set itemsToShow(value: number) {
        if (value < this._itemsToShow) {
            this.upperBound = this.upperBound - (this.upperBound - value);
        } else {
            this.upperBound = this.upperBound + (value - this.upperBound);
        }
        this._itemsToShow = value;
    }

    goToSelectedPage() {
        if (this.currentPage !== 0) {
            this.lowerBound = (this.currentPage - 1) * this.itemsToShow;
            this.upperBound = (this.currentPage - 1) * this.itemsToShow + this.itemsToShow;
        } else {
            this.lowerBound = 0;
            this.upperBound = this.itemsToShow;
        }

        let params = this.routingService.queryParams;
        params.page = this.currentPage;
        this.routingService.replace(params);
    }

    goToFirstPage(callback?: Function) {
        callback = callback || (() => { });
        this.currentPage = 1;
        this.goToSelectedPage();
        callback();
    }

    goToLastPage(callback?: Function) {
        callback = callback || (() => { });
        this.currentPage = this.maxPage();
        this.goToSelectedPage();
        callback();
    }

    maxPage() {
        return Math.ceil(this.total / this.itemsToShow);
    }
}