import {
    IUserService,
    IModalService,
    IAuthenticationService
} from "../../../Interfaces/interfaces";


export class TopPanelController {
    static $inject = ["UserService", "AuthenticationService", "ModalService"];

    constructor(private userService: IUserService, private authService: IAuthenticationService, private modalService: IModalService) {

    }

    logIn() {
        this.modalService.openLoginModal().result.then(() => { }).catch(() => { });
    }

    logOut() {
        this.authService.logOff().catch(err => {
            console.log(err.data.message);
        });
    }
}