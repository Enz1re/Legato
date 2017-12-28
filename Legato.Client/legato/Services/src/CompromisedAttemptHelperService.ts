﻿import { CompromisedAttempt } from "../../Models/models";

import { ICompromisedAttemptHelperService } from "../../Interfaces/interfaces";


export default class CompromisedAttemptHelperService implements ICompromisedAttemptHelperService {
    private _checkedAttempts: CompromisedAttempt[] = [];
    pristine: boolean = false;
    allCompromisedAttempts: CompromisedAttempt[] = [];

    constructor() {
        this.pristine = false;
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
        this._checkedAttempts.splice(this._checkedAttempts.indexOf(attempt), 1);
    }

    removeAttempt(attempt: CompromisedAttempt) {
        this.pristine = true;
        this.allCompromisedAttempts.splice(this.allCompromisedAttempts.indexOf(attempt), 1);
        this.removeAttemptFromCheckList(attempt);
    }

    selectAll() {
        this.allCompromisedAttempts.forEach(value => {
            if (this._checkedAttempts.indexOf(value) === -1) {
                this._checkedAttempts.push(value);
            }
        });
    }

    deselectAll() {
        this._checkedAttempts = [];
    }

    clear() {
        this.pristine = false;
        this._checkedAttempts = [];
        this.allCompromisedAttempts = [];
    }
}