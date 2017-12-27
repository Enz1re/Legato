import {
    Price,
    Vendor,
    Sorting
} from "../../../Models/models";

import {
    IUserService,
    IModalService,
    IFilterService,
    IVendorService,
    IUpdateService,
    IRoutingService,
    IAuthenticationService
} from "../../../Interfaces/interfaces";

import { Constants } from "../../../Constants";


export class MainController implements ng.IController {
    error = false;
    activeTab: string;
    search: string;
    static $inject = ["$scope", "RoutingService", "UpdateService", "FilterService", "VendorService", "AuthenticationService", "ModalService", "UserService"];

    constructor(private $scope: ng.IScope, private routingService: IRoutingService, private updateService: IUpdateService, private filterService: IFilterService,
                private service: IVendorService, private authService: IAuthenticationService, private modalService: IModalService, private userService: IUserService) {
        const name = routingService.urlSegments[1];
        this.initVendorList(name).then(() => {
            this.activeTab = name;
            const urlParamResolver = routingService.getParamResolver();
            this.updateService.filter.price = urlParamResolver.resolvePrice();
            this.updateService.filter.sorting = urlParamResolver.resolveSorting();
            this.updateService.filter.vendors = urlParamResolver.resolveVendors(this.updateService.filter.vendors);
            this.updateService.filter.search = this.search = urlParamResolver.resolveSearchString();
        });
        $scope.$watch(() => this.userService.currentUser, (newVal, oldVal) => {
            if (newVal || oldVal) {
                if ((newVal && !oldVal) || (!newVal && oldVal) || (newVal.username !== oldVal.username)) {
                    this.userService.currentUser = newVal;
                }
            }
        }, true);
    }

    checkTab(click, guitarTypeName: string) {
        if (this.activeTab === guitarTypeName || click === undefined) {
            return;
        }

        this.activeTab = guitarTypeName;
        this.updateService.filter.price = this.filterService.guitarFilter[guitarTypeName].price || new Price();
        this.updateService.filter.sorting = this.filterService.guitarFilter[guitarTypeName].sorting || new Sorting();
        this.updateService.filter.search = this.search = this.filterService.guitarFilter[guitarTypeName].search;

        if (!this.filterService.guitarFilter[guitarTypeName].vendors) {
            this.initVendorList(guitarTypeName);
        } else {
            this.updateService.filter.vendors = this.filterService.guitarFilter[guitarTypeName].vendors;
        }
        
        this.routingService.redirect(this.activeTab, this.filterService.guitarFilter[guitarTypeName].params || { page: "1" });
    }

    onTabDeselected(event, guitarTypeName: string) {
        if (event === undefined) {
            return;
        }

        this.filterService.guitarFilter[guitarTypeName].params = { ...this.routingService.queryParams };
        this.filterService.guitarFilter[guitarTypeName].price = { ...this.updateService.filter.price };
        this.filterService.guitarFilter[guitarTypeName].vendors = [ ...this.updateService.filter.vendors ];
        this.filterService.guitarFilter[guitarTypeName].sorting = { ...this.updateService.filter.sorting };
        this.filterService.guitarFilter[guitarTypeName].search = this.search = this.updateService.filter.search;
    }

    unfilter() {
        this.updateService.filter.search = this.search = "";
        this.updateService.filter.price = { from: null, to: null };
        this.updateService.filter.sorting = {
            required: false,
            name: null,
            direction: null
        };
        this.updateService.filter.vendors.forEach(v => {
            v.isSelected = true;
        });
    }

    logOut() {
        this.authService.logOff().catch(err => {
            console.log(err.data.message);
        });
    }

    doSearch(event) {
        if (event.key.toLowerCase() === "enter") {
            this.updateService.filter.search = this.search;
        }
    }

    logIn() {
        this.modalService.openLoginModal().result.then(() => { }).catch(() => { });
    }

    private initVendorList(guitarTypeName: string): ng.IPromise<void> {
        this.updateService.filter.vendors = [];

        switch (guitarTypeName) {
            case Constants.CLASSICAL:
                return this.refreshVendorListForClassicalGuitars()
            case Constants.WESTERN:
                return this.refreshVendorListForWesternGuitars();
            case Constants.ELECTRIC:
                return this.refreshVendorListForElectricGuitars();
            case Constants.BASS:
                return this.refreshVendorListForBassGuitars();
        }
    }

    private refreshVendorListForClassicalGuitars() {
        return this.service.getClassicalGuitarVendors().then(vendors => {
            this.updateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }

    private refreshVendorListForWesternGuitars() {
        return this.service.getWesternGuitarVendors().then(vendors => {
            this.updateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }

    private refreshVendorListForElectricGuitars() {
        return this.service.getElectricGuitarVendors().then(vendors => {
            this.updateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }

    private refreshVendorListForBassGuitars() {
        return this.service.getBassGuitarVendors().then(vendors => {
            this.updateService.filter.vendors = vendors;
        }).catch(err => {
            this.error = true;
            throw err;
        });
    }
}