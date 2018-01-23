import CompromisedAttemptHelperService from "../src/CompromisedAttemptHelperService";

import { CompromisedAttempt } from "../../Models/models";

import { ICompromisedAttemptHelperService } from "../../Interfaces/interfaces";

// all tokens have been randomly generated and present just fake data
const compromisedAttempts: CompromisedAttempt[] = [
    { attemptId: 0, compromisedToken: "2FEBC94679A24C50941186F2BE0293C1", requestIP: "::1", username: "User1", requestDateTime: new Date(), isSelected: false },
    { attemptId: 1, compromisedToken: "D254BE2B1A2B4BC389F88F1D1F37BF6C", requestIP: "::1", username: "User2", requestDateTime: new Date(), isSelected: false },
    { attemptId: 2, compromisedToken: "B128AC34C6A348DFBDC6E38619094109", requestIP: "::1", username: "User3", requestDateTime: new Date(), isSelected: false },
    { attemptId: 3, compromisedToken: "E340215BBA174388A2DAC03DB7625F7F", requestIP: "::1", username: "User4", requestDateTime: new Date(), isSelected: false },
    { attemptId: 4, compromisedToken: "58B81F093CFF43F1B99C25D2DC7CCBAD", requestIP: "::1", username: "User5", requestDateTime: new Date(), isSelected: false },
    { attemptId: 5, compromisedToken: "73036EA7B5974F9794F5DDB0A9EE70E3", requestIP: "::1", username: "User6", requestDateTime: new Date(), isSelected: false },
    { attemptId: 6, compromisedToken: "DAC556A0178C47A1AB433D1B7B22B3EB", requestIP: "::1", username: "User7", requestDateTime: new Date(), isSelected: false },
    { attemptId: 7, compromisedToken: "43417913E75D4A1FA62ADF63EC48814D", requestIP: "::1", username: "User8", requestDateTime: new Date(), isSelected: false },
    { attemptId: 8, compromisedToken: "4B61CEA0F61F497B84FB036CD8B308B9", requestIP: "::1", username: "User9", requestDateTime: new Date(), isSelected: false },
    { attemptId: 9, compromisedToken: "DB08BFDD558E4B68A6785BEFAB2E8CD8", requestIP: "::1", username: "User10", requestDateTime: new Date(), isSelected: false },
];


describe("CompromisedAttemptHelperService", () => {
    let compromisedAttemptsService: ICompromisedAttemptHelperService;

    beforeEach(() => {
        compromisedAttemptsService = new CompromisedAttemptHelperService();
        compromisedAttemptsService.allCompromisedAttempts = [...compromisedAttempts];
    });

    it("sets 'pristine' value to false", () => {
        expect(compromisedAttemptsService.changed).toBe(false);
    });

    it("adds attempt to checklist", () => {
        compromisedAttemptsService.addAttemptToCheckList({
            attemptId: 10,
            compromisedToken: "7BDC8AB5690940BA8F1455531EE0609E",
            requestIP: "::1",
            username: "User11",
            requestDateTime: new Date(),
            isSelected: false
        });
        expect(compromisedAttemptsService.checkedCompromisedAttempts.length).toBe(1);
    });

    it("doesn't add existing attempt to checklist", () => {
        compromisedAttemptsService.addAttemptToCheckList(compromisedAttempts[0]);
        compromisedAttemptsService.addAttemptToCheckList(compromisedAttempts[0]);
        expect(compromisedAttemptsService.checkedCompromisedAttempts.length).toBe(1);
    });

    it("removes attempt from compromised attempts", () => {
        compromisedAttemptsService.removeAttempt(compromisedAttempts[4]);
        expect(compromisedAttemptsService.changed).toBe(true);
        expect(compromisedAttemptsService.allCompromisedAttempts.length).toEqual(9);
        expect(compromisedAttemptsService.allCompromisedAttempts[3]).toBe(compromisedAttempts[3]);
        expect(compromisedAttemptsService.allCompromisedAttempts[4]).toBe(compromisedAttempts[5]);
    });

    it("selects all previously added attempts", () => {
        compromisedAttemptsService.selectAll();
        expect(compromisedAttemptsService.allCompromisedAttempts).toEqual(compromisedAttemptsService.checkedCompromisedAttempts);
        expect(compromisedAttemptsService.allCompromisedAttempts.filter(attempt => attempt.isSelected).length).toBe(10);
    });

    it("deselects all previously selected attempts", () => {
        for (let i = 0; i < compromisedAttemptsService.allCompromisedAttempts.length; i++) {
            compromisedAttemptsService.allCompromisedAttempts[i].isSelected = true;
        }

        compromisedAttemptsService.deselectAll();
        expect(compromisedAttemptsService.allCompromisedAttempts.filter(attempt => !attempt.isSelected).length).toBe(10);
    });

    it("clears compromised attempt lists", () => {
        compromisedAttemptsService.clear();
        expect(compromisedAttemptsService.changed).toBe(false);
        expect(compromisedAttemptsService.allCompromisedAttempts.length).toBe(0);
        expect(compromisedAttemptsService.checkedCompromisedAttempts.length).toBe(0);
    });
});