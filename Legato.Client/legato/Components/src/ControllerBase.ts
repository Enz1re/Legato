import {
    Price,
    Guitar,
    Paging,
    Sorting,
    ClassicalGuitar
} from "../../Models/models";

import { IGuitarService } from "../../Interfaces/interfaces";


export abstract class ControllerBase<TGuitar extends Guitar> {
    noResults: boolean;
    guitars: TGuitar[];
    price: Price;
    vendors: string[];
    sorting: Sorting = new Sorting();
    error = false;
    paging: Paging = new Paging();

    constructor(protected service: IGuitarService<TGuitar>) {
        this.init();
    }
    
    protected onPageChanged() {
        this.paging.goNext();
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
}