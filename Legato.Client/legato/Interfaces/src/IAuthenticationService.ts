export interface IAuthenticationService {
    login(username: string, password: string): ng.IPromise<string>;
    setCredentials(username: string, accessToken: string);
    clearCredentials();
}