import { CompromisedAttempt } from "../../Models/models";

import { ICompromisedAttemptHelperService } from "../../Interfaces/interfaces";


export default class CompromisedAttemptHelperService implements ICompromisedAttemptHelperService {
    private _checkedAttempts: CompromisedAttempt[] = [];
    changed: boolean;
    allCompromisedAttempts: CompromisedAttempt[] = [];

    constructor() {
        this.changed = false;
    }

    get checkedCompromisedAttempts() {
        return this._checkedAttempts;
    }

    addAttemptToCheckList(attempt: CompromisedAttempt) {
        if (this._checkedAttempts.indexOf(attempt) === -1) {
            this._checkedAttempts.push(attempt);
        }
    }

    removeAttemptFromCheckList(attempt: CompromisedAttempt) {
        const index = this.allCompromisedAttempts.indexOf(attempt);

        if (index !== -1) {
            this._checkedAttempts.splice(this._checkedAttempts.indexOf(attempt), 1);
        }
    }

    removeAttempt(attempt: CompromisedAttempt) {
        const index = this.allCompromisedAttempts.indexOf(attempt);

        if (index !== -1) {
            this.changed = true;
            this.allCompromisedAttempts.splice(index, 1);
            this.removeAttemptFromCheckList(attempt);
        }
    }

    selectAll() {
        this.allCompromisedAttempts.forEach(value => {
            if (this._checkedAttempts.indexOf(value) === -1) {
                this._checkedAttempts.push(value);
            }
        });
        this.allCompromisedAttempts.forEach(attempt => {
            attempt.isSelected = true;
        });
    }

    deselectAll() {
        this._checkedAttempts = [];
        this.allCompromisedAttempts.forEach(attempt => {
            attempt.isSelected = false;
        });
    }

    clear() {
        this.changed = false;
        this._checkedAttempts = [];
        this.allCompromisedAttempts = [];
    }
}