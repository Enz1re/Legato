export interface IPagingService {
    total: number;
    lowerBound: number;
    upperBound: number;
    currentPage: number;
    itemsToShow: number;

    goToSelectedPage(): void;
    goToLastPage(callback: Function): void;
    goToFirstPage(callback: Function): void;
    maxPage(): number;
}