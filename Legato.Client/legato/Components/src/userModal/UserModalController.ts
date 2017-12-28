import { UserViewModel } from "../../../Models/models";

import { IUserService, IContextMenuService } from "../../../Interfaces/interfaces";


export class UserModalController {
    users: UserViewModel[];
    static $inject = ["$uibModalInstance", "UserService", "ContextMenuService", "users"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, private userService: IUserService,
                private contextMenu: IContextMenuService, users: UserViewModel[]) {
        this.users = users;
    }

    blockUserSession(username: string) {

    }

    onOkButtonClicked() {
        this.$uibModalInstance.close();
    }
}