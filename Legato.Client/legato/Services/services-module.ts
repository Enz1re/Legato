import angular from "angular";

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
import FilterService from "./src/FilterService";
import ManageService from "./src/ManageService";
import PagingService from "./src/PagingService";
import VendorService from "./src/VendorService";
import UpdateService from "./src/UpdateService";
import CacheService from "./src/CacheService";
import ModalService from "./src/ModalService";
import Base64 from "./src/Base64";

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
    .service("FilterService", FilterService)
    .service("PagingService", PagingService)
    .service("ModalService", ModalService)
    .service("AuthenticationService", AuthenticationService)
    .service("Base64", Base64)
    .service("ManageService", ManageService)
    .service("ContextMenuService", ContextMenuService)
    .service("FileUploadService", FileUploadService)
    .service("GuitarDataService", GuitarDataService);

export {
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
    FilterService,
    UpdateService,
    VendorService,
    CacheService,
    ModalService,
    Base64
};

export default servicesModuleName;