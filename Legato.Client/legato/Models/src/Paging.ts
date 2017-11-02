export default class Paging {
    lowerBound: number;
    upperBound: number;
    total: number;
    currentPage: number;
    itemsToShow: number;

    constructor(lowerBound: number, upperBound: number) {
        this.lowerBound = lowerBound;
        this.upperBound = upperBound;
        this.currentPage = 0;
        this.itemsToShow = 20;
    }
}