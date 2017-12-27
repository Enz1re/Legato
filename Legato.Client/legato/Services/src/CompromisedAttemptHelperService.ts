import { CompromisedAttempt } from "../../Models/models";

import { ICompromisedAttemptHelperService } from "../../Interfaces/interfaces";


export default class CompromisedAttemptHelperService implements ICompromisedAttemptHelperService {
    private _checkedAttempts: CompromisedAttempt[] = [];

    allCompromisedAttempts: CompromisedAttempt[] = [];

    get checkedCompromisedAttempts() {
        return this._checkedAttempts;
    }

    addAttemptToCheckList(attempt: CompromisedAttempt) {
        if (this._checkedAttempts.indexOf(attempt) === -1) {
            this._checkedAttempts.push(attempt);
        }
    }

    removeAttemptFromCheckList(attempt: CompromisedAttempt) {
        this._checkedAttempts.splice(this._checkedAttempts.indexOf(attempt), 1);
    }

    removeAttempt(attempt: CompromisedAttempt) {
        this.allCompromisedAttempts.splice(this.allCompromisedAttempts.indexOf(attempt), 1);
    }
}