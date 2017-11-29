import { User, UrlParams } from "../../../Models/models";

import {
    IModalService,
    IRoutingService,
    IAuthenticationService
} from "../../../Interfaces/interfaces";


export class LoginController implements ng.IController {
    loggedInUser: User;
    static $inject = ["ModalService", "RoutingService", "prevState"];
    private prevState: {
        name: string,
        params: any
    };

    constructor(private modalService: IModalService, private routingService: IRoutingService, prevState) {
        this.prevState = prevState;
        console.log(prevState);
        this.modalService.openLoginModal({}).result.then((user: User) => {
            this.loggedInUser = user;
            this.routingService.redirect(this.prevState.name, this.prevState.params);
        }).catch(err => {
            this.routingService.redirect(this.prevState.name, this.prevState.params);
        });
    }
}