export interface IAuthenticationService {
    login(username: string, password: string): ng.IPromise<boolean>;
    setCredentials(username, password);
    clearCredentials();
}