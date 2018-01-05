import { IAntiforgeryService } from "../../Interfaces/interfaces";


export default class AntiforgeryService implements IAntiforgeryService {
    antiforgeryTokenGet: string;
    antiforgeryTokenPost: string;
    antiforgeryTokenDelete: string;

    constructor(private $http: ng.IHttpService) {

    }

    getTokens() {
        return this.$http.get("http://localhost/api/Manage/Tokens").then((tokens: ng.IHttpResponse<any>) => {
            this.antiforgeryTokenGet = tokens.data.antiforgeryTokenGet;
            this.antiforgeryTokenPost = tokens.data.antiforgeryTokenPost;
            this.antiforgeryTokenDelete = tokens.data.antiforgeryTokenDelete;
        });
    }
}