import angular from "angular";

import CompromisedAttemptHelperService from "./src/CompromisedAttemptHelperService";
import ClassicalGuitarService from "./src/ClassicalGuitarService";
import AuthenticationService from "./src/AuthenticationService";
import ElectricGuitarService from "./src/ElectricGuitarService";
import WesternGuitarService from "./src/WesternGuitarService";
import ContextMenuService from "./src/ContextMenuService";
import PendingTaskService from "./src/PendingTaskService";
import BassGuitarService from "./src/BassGuitarService";
import GuitarDataService from "./src/GuitarDataService";
import FileUploadService from "./src/FileUploadService";
import UrlParamResolver from "./src/UrlParamResolver";
import GuitarResource from "./src/GuitarResource";
import RoutingService from "./src/RoutingService";
import FilterStateService from "./src/FilterService";
import ManageService from "./src/ManageService";
import PagingService from "./src/PagingService";
import VendorService from "./src/VendorService";
import UpdateService from "./src/UpdateService";
import CacheService from "./src/CacheService";
import ClaimService from "./src/ClaimService";
import ModalService from "./src/ModalService";
import UserResource from "./src/UserResource";
import UserService from "./src/UserService";
import SHA1 from "./src/SHA1";

const servicesModuleName = "legato.services";

angular.module(servicesModuleName, [])
    .service("ClassicalGuitarService", ClassicalGuitarService)
    .service("ElectricGuitarService", ElectricGuitarService)
    .service("WesternGuitarService", WesternGuitarService)
    .service("BassGuitarService", BassGuitarService)
    .service("PendingTaskService", PendingTaskService)
    .service("GuitarResource", GuitarResource)
    .service("VendorService", VendorService)
    .service("CacheService", CacheService)
    .service("RoutingService", RoutingService)
    .service("UpdateService", UpdateService)
    .service("FilterStateService", FilterStateService)
    .service("PagingService", PagingService)
    .service("ModalService", ModalService)
    .service("AuthenticationService", AuthenticationService)
    .service("ManageService", ManageService)
    .service("ContextMenuService", ContextMenuService)
    .service("FileUploadService", FileUploadService)
    .service("GuitarDataService", GuitarDataService)
    .service("UserResource", UserResource)
    .service("UserService", UserService)
    .service("ClaimService", ClaimService)
    .service("SHA1", SHA1)
    .service("CompromisedAttemptHelperService", CompromisedAttemptHelperService);

export {
    CompromisedAttemptHelperService,
    ClassicalGuitarService,
    AuthenticationService,
    ElectricGuitarService,
    WesternGuitarService,
    PendingTaskService,
    BassGuitarService,
    FileUploadService,
    GuitarDataService,
    UrlParamResolver,
    GuitarResource,
    RoutingService,
    PagingService,
    FilterStateService,
    UpdateService,
    VendorService,
    CacheService,
    ModalService,
    SHA1
};

export default servicesModuleName;