import {
    Price,
    Guitar,
    Paging,
    Sorting,
    ClassicalGuitar
} from "../../Models/models";

import { IGuitarService } from "../../Interfaces/interfaces";


export abstract class ControllerBase<TGuitar extends Guitar> {
    protected guitars: TGuitar[];
    protected price: Price;
    protected vendors: string[];
    protected sorting: Sorting = new Sorting();
    protected error = false;
    protected paging: Paging = new Paging();

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
        this.error = false;

        if (this.sorting.required) {
            this.service.getSortedGuitars(this.price, this.vendors, this.paging, this.sorting.name, this.sorting.direction).then(guitars => {
                this.guitars = guitars;
            }).catch(err => {
                this.error = true;
            });
        } else {
            this.service.getGuitars(this.price, this.vendors, this.paging).then(guitars => {
                this.guitars = guitars;
            }).catch(err => {
                this.error = true;
            });
        }
    }
}