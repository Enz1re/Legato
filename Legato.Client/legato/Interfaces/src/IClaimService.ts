import { LegatoClaims } from "../../Models/models";


export interface IClaimService {
    claims: LegatoClaims;
    hasAdminRights(): boolean;
    getUserClaims(): ng.IPromise<LegatoClaims>;
}