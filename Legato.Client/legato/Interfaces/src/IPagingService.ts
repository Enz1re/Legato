export interface IPagingService {
    total: number;
    lowerBound: number;
    upperBound: number;
    currentPage: number;
    itemsToShow: number;

    goToPage(): void;
    goToFirstPage(callback: Function): void;
    maxPage(): number;
}