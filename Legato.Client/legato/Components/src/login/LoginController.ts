import { User } from "../../../Models/models";


export class LoginController implements ng.IController {
    user: User = new User();

    constructor() {

    }
}