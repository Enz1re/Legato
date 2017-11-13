export default class Paging {
    total: number;
    lowerBound: number;
    upperBound: number;
    currentPage: number;
    itemsToShow: number;

    constructor() {
        this.itemsToShow = 20;
        this.lowerBound = 0;
        this.upperBound = this.itemsToShow;
    }

    goToPage() {
        this.lowerBound = (this.currentPage - 1) * this.itemsToShow;
        this.upperBound = (this.currentPage - 1) * this.itemsToShow + this.itemsToShow;
    }

    toJSON() {
        return JSON.stringify({ lowerBound: this.lowerBound, upperBound: this.upperBound });
    }
}