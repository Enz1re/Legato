import { IPagingService } from "../../../Interfaces/interfaces";


export class PaginationController {
    static $inject = ["PagingService"];

    constructor (private pagingService: IPagingService) {
        
    }
}