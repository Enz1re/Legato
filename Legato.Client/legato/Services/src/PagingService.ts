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

    goToPage() {
        if (this.currentPage !== 0) {
            this.lowerBound = (this.currentPage - 1) * this.itemsToShow;
            this.upperBound = (this.currentPage - 1) * this.itemsToShow + this.itemsToShow;
        } else {
            this.lowerBound = 0;
            this.upperBound = this.itemsToShow;
        }
    }

    goToFirstPage(callback: Function) {
        callback = callback || (() => { });
        this.currentPage = 1;
        this.goToPage();
        callback();
    }

    maxPage() {
        return Math.floor(this.total / this.itemsToShow);
    }
}