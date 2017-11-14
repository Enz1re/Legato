import {
    Price,
    Guitar,
    Paging,
    Sorting,
    ClassicalGuitar
} from "../../Models/models";

import { IGuitarService, IRoutingService } from "../../Interfaces/interfaces";


export abstract class ControllerBase<TGuitar extends Guitar> {
    noResults: boolean;
    guitars: TGuitar[];
    price: Price = new Price;
    vendors: string[];
    sorting: Sorting = new Sorting();
    error = false;
    paging: Paging = new Paging();

    constructor(protected service: IGuitarService<TGuitar>, protected routingService: IRoutingService) {
        this.paging.currentPage = routingService.getParamResolver().resolvePage();
        this.init();
    }
    
    protected onPageChanged(guitarName: string) {
        this.paging.goToPage();
        this.routingService.go(guitarName, this.formGetParams());
        this.loadGuitarList();
    }

    protected init() {
        this.error = false;

        this.service.getAmount(this.price, this.vendors).then(amount => {
            this.paging.total = amount;
        }).then(() => {
            this.loadGuitarList();
        }).catch(err => {
            this.error = true;
        });
    }

    protected loadGuitarList() {
        this.guitars = [];
        this.error = false;

        if (this.sorting.required) {
            this.service.getSortedGuitars(this.price, this.vendors, this.paging, this.sorting.name, this.sorting.direction).then(guitars => {
                this.noResults = guitars.length === 0;
                this.guitars = guitars;
            }).catch(err => {
                this.error = true;
            });
        } else {
            this.service.getGuitars(this.price, this.vendors, this.paging).then(guitars => {
                this.noResults = guitars.length === 0;
                this.guitars = guitars;
            }).catch(err => {
                this.error = true;
            });
        }
    }

    private formGetParams(): any {
        let params: any = { page: this.paging.currentPage };

        if (this.price && this.price.from && this.price.to) {
            params.from = this.price.from;
            params.to = this.price.to;
        }
        if (this.vendors) {
            params.vendors = this.vendors.join();
        }
        if (this.sorting && this.sorting.required) {
            params.name = this.sorting.name;
            params.direction = this.sorting.direction;
        }

        return params;
    }
}