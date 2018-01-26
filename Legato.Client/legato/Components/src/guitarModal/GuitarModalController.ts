import { Guitar } from "../../../Models/models";

import { IRoutingService } from "../../../Interfaces/interfaces";


export class GuitarModalController {
    guitars: Guitar[];
    currentIndex: number;
    static $inject = ["RoutingService", "guitars", "currentIndex"];

    constructor(private routingService: IRoutingService, guitars: Guitar[], currentIndex: number) {
        this.guitars = guitars;
        this.currentIndex = currentIndex >= guitars.length ? guitars.length - 1 :
                                currentIndex < 0 ? 0 :
                                    currentIndex;
    }

    next() {
        if (this.currentIndex === this.guitars.length - 1) {
            return;
        }

        this.currentIndex++;
        this.replaceParams();
    }

    prev() {
        if (this.currentIndex === 0) {
            return;
        }

        this.currentIndex--;
        this.replaceParams();
    }

    private replaceParams() {
        let params = this.routingService.queryParams;
        params.g = this.currentIndex;
        this.routingService.replace(params);
    }

    private isNextDisabled() {
        return this.currentIndex >= this.guitars.length - 1;
    }

    private isPrevDisabled() {
        return this.currentIndex <= 0;
    }
}