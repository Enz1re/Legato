import { CompromisedAttempt } from "../../Models/models";


export interface ICompromisedAttemptHelperService {
    allCompromisedAttempts: CompromisedAttempt[];
    checkedCompromisedAttempts: CompromisedAttempt[];

    addAttemptToCheckList(attempt: CompromisedAttempt);
    removeAttemptFromCheckList(attempt: CompromisedAttempt);
    removeAttempt(attempt: CompromisedAttempt);
}