import { CompromisedAttempt } from "../../Models/models";


export interface ICompromisedAttemptHelperService {
    getAttempts(): CompromisedAttempt[];
    addAttempt(attempt: CompromisedAttempt);
}