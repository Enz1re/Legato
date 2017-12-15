import { User } from "../../../Models/models";

import { IAuthenticationService } from "../../../Interfaces/interfaces";


export class LoginModalController {
    messaging = {
        loading: false,
        error: true,
        message: "",
    };
    user: User = new User();
    static $inject = ["$uibModalInstance", "AuthenticationService"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, private authService: IAuthenticationService) {

    }

    onOkButtonPressed() {
        this.messaging.loading = true;
        this.authService.login(this.user.username, this.user.password).then((accessToken: string) => {
            this.authService.setCredentials(this.user.username, accessToken);
            this.messaging.loading = false;
            this.$uibModalInstance.close(this.user);
        }).catch(err => {
            this.messaging.loading = false;
            this.messaging.error = true;
            this.messaging.message = err.data.message;
        });
    }

    onCancelPressed() {
        this.$uibModalInstance.dismiss();
    }
}