import { IHttpService } from '../../../Interfaces/interfaces';


export class LegatoLoaderDirective implements ng.IDirective {
    private loaderHtml: JQLite;
    restrict = 'A';

    constructor(private $compile: ng.ICompileService, private http: IHttpService) {
        
    }

    link(scope, elem: JQLite, attrs) {
        this.http.getHtmlContents('legato/Directives/src/loading/loader.html').then(html => {
            this.loaderHtml = this.$compile(this.loaderHtml)(scope);
        });

        scope.isLoading = () => {
            return this.http.hasPendingRequests();
        }

        scope.$watch(scope.isLoading, val => {
            if (val) {
                elem.prepend(this.loaderHtml);
            } else {
                this.loaderHtml.remove();
            }
        });
    }

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = ($compile: ng.ICompileService, http: IHttpService) => new LegatoLoaderDirective($compile, http);
        directive.$inject = ['$compile', 'HttpService'];
        return directive;
    }
}