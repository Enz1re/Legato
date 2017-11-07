export default class Paging {
    lowerBound: number;
    upperBound: number;
    total: number;
    currentPage: number;
    itemsToShow: number;

    constructor() {
        this.itemsToShow = 20;
        this.goToFirstPage();
    }

    goToFirstPage() {
        this.currentPage = 1;
        this.lowerBound = 0;
        this.upperBound = this.itemsToShow;
    }

    goNext() {
        this.lowerBound = (this.currentPage - 1) * this.itemsToShow;
        this.upperBound = (this.currentPage - 1) * this.itemsToShow + this.itemsToShow;
    }

    toJsonString() {
        return JSON.stringify({ lowerBound: this.lowerBound, upperBound: this.upperBound });
    }
}