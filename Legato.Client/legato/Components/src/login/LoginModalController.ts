import { IUserService, IAuthenticationService } from "../../../Interfaces/interfaces";


export class LoginModalController {
    static $inject = ["$uibModalInstance", "AuthenticationService", "UserService"];
    messaging = {
        loading: false,
        error: true,
        message: "",
    };
    private username: string;
    private password: string;

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, private authService: IAuthenticationService, private userService: IUserService) {

    }

    onSignInButtonPressed() {
        this.messaging.loading = true;
        if (this.userService.authenticated) {
            this.authService.logOff().then(() => { this.login(); });
        } else {
            this.login();
        }
    }

    onCancelPressed() {
        this.$uibModalInstance.dismiss();
    }

    private login() {
        this.authService.login(this.username, this.password).then((accessToken: string) => {
            this.$uibModalInstance.close();
        }).catch(err => {
            this.messaging.error = true;
            this.messaging.message = err.data.message;
        });
    }
}