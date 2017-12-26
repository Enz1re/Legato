import { CompromisedAttempt } from "../../Models/models";

import { ICompromisedAttemptHelperService } from "../../Interfaces/interfaces";


export default class CompromisedAttemptHelperService implements ICompromisedAttemptHelperService {
    private _compromisedAttempts: CompromisedAttempt[];

    getAttempts(): CompromisedAttempt[] {
        return this._compromisedAttempts;
    }

    addAttempt(attempt: CompromisedAttempt) {
        if (this._compromisedAttempts.indexOf(attempt) === -1) {
            this._compromisedAttempts.push(attempt);
        }
    }
}