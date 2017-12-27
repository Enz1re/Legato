import { IAuthenticationService } from "../../../Interfaces/interfaces";


export class LoginModalController {
    messaging = {
        loading: false,
        error: true,
        message: "",
    };
    private username: string;
    private password: string;
    static $inject = ["$uibModalInstance", "AuthenticationService"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, private authService: IAuthenticationService) {

    }

    onOkButtonPressed() {
        this.messaging.loading = true;
        this.authService.login(this.username, this.password).then((accessToken: string) => {
            this.$uibModalInstance.close();
        }).catch(err => {
            this.messaging.error = true;
            this.messaging.message = err.data.message;
        });
    }

    onCancelPressed() {
        this.$uibModalInstance.dismiss();
    }
}