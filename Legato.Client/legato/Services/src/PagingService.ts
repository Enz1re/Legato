import { IPagingService, IManageService } from "../../Interfaces/interfaces";


export default class PagingService implements IPagingService {
    static $inject = ["ManageService"];
    total: number;
    lowerBound: number;
    upperBound: number;
    currentPage: number;
    itemsToShow: number;

    constructor(private manageService: IManageService) {
        manageService.getDisplayAmount().then(amount => {
            this.itemsToShow = amount;
            this.lowerBound = 0;
            this.upperBound = this.itemsToShow;
        });
    }

    goToSelectedPage() {
        if (this.currentPage !== 0) {
            this.lowerBound = (this.currentPage - 1) * this.itemsToShow;
            this.upperBound = (this.currentPage - 1) * this.itemsToShow + this.itemsToShow;
        } else {
            this.lowerBound = 0;
            this.upperBound = this.itemsToShow;
        }
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