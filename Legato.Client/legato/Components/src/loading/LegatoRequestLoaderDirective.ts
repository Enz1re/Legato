export class LegatoRequestLoaderDirective implements ng.IDirective {
    restrict = "E";
    scope = {
        size: "@"
    };
    replace = true;
    templateUrl = "legato/Components/src/loading/legatoLoader.html";

    static create() {
        const directive: ng.IDirectiveFactory = () => new LegatoRequestLoaderDirective();
        return directive;
    }
}