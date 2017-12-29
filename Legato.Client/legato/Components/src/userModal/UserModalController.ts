import { UserViewModel } from "../../../Models/models";

import {
    IUserService,
    IModalService,
    IContextMenuService
} from "../../../Interfaces/interfaces";


export class UserModalController {
    private numUsersToPreload = 25;
    private lowerBound = 0;
    private upperBound = this.numUsersToPreload;
    allUsersLoaded: boolean = false;
    loading: boolean;
    users: UserViewModel[] = [];
    static $inject = ["$uibModalInstance", "ModalService", "UserService", "ContextMenuService"];

    constructor(private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, private modalService: IModalService,
                private userService: IUserService, private contextMenu: IContextMenuService) {
        this.preloadUserList();
    }

    blockUserSession(user: UserViewModel) {
        this.modalService.openYesNoDialog(`Are you sure you want to block user ${user.name}? This action is irreversible.`).result.then(() => {
            this.userService.blockUser(user.name).then(() => {
                user.isAuthenticated = false;
            }).catch(err => {
                this.modalService.openAlertModal(err.data.message, "danger").result.catch(() => { });
            });
        }).catch(() => { });
    }

    loadUsers() {
        this.lowerBound += this.numUsersToPreload;
        this.upperBound += this.numUsersToPreload;

        this.preloadUserList();
    }

    onOkButtonClicked() {
        this.$uibModalInstance.close();
    }

    private preloadUserList() {
        this.loading = true;
        return this.userService.getUsers(this.lowerBound, this.upperBound).then(users => {
            this.loading = false;
            // if service method returned empty array, than the complete user list has been received from the server
            if (users.length > 0) {
                this.users = this.users.concat(users);
            } else {
                this.allUsersLoaded = true;
            }
        });
    }
}