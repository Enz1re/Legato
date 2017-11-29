import { LoginModalController } from "../../src/login/LoginModalController";


export class LoginModalComponent {
    bindings = {
        resolve: "<",
        close: "&",
        dismiss: "&"
    };
    templateUrl = "legato/Components/src/login/loginModal.html";

    static create() {
        return new LoginModalComponent();
    }
}