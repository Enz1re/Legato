﻿import { CompromisedAttempt } from "../../Models/models";


export interface ICompromisedAttemptHelperService {
    pristine: boolean;
    allCompromisedAttempts: CompromisedAttempt[];
    checkedCompromisedAttempts: CompromisedAttempt[];

    addAttemptToCheckList(attempt: CompromisedAttempt);
    removeAttemptFromCheckList(attempt: CompromisedAttempt);
    removeAttempt(attempt: CompromisedAttempt);
    selectAll();
    deselectAll();
    clear();
}