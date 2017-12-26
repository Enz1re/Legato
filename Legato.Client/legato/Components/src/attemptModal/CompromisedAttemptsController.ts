import { CompromisedAttempt } from "../../../Models/models";

import {
    IUserService,
    IContextMenuService,
    ICompromisedAttemptHelperService
} from "../../../Interfaces/interfaces";


export class CompromisedAttemptsController {
    compromisedAttempts: CompromisedAttempt[];
    static $inject = ["ContextMenuService", "UserService", "CompromisedAttemptHelperService", "compromisedAttempts"];

    constructor(private contextMenu: IContextMenuService, private userService: IUserService,
                private attemptService: ICompromisedAttemptHelperService, compromisedAttempts: CompromisedAttempt[]) {

    }

    removeAttempt(attempt: CompromisedAttempt) {
        this.userService.removeCompromisedAttempts([attempt.attemptId]).then(() => {

        }).catch(() => { });
    }
}