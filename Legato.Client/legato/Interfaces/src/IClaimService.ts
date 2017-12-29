import { LegatoClaims } from "../../Models/models";


export interface IClaimService {
    claims: LegatoClaims;

    getUserClaims();
}