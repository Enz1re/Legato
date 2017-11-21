import angular from "angular";

import ClassicalGuitarService from "./src/ClassicalGuitarService";
import ElectricGuitarService from "./src/ElectricGuitarService";
import WesternGuitarService from "./src/WesternGuitarService";
import FilterUpdateService from "./src/FilterUpdateService";
import PendingTaskService from "./src/PendingTaskService";
import BassGuitarService from "./src/BassGuitarService";
import UrlParamResolver from "./src/UrlParamResolver";
import GuitarResource from "./src/GuitarResource";
import RoutingService from "./src/RoutingService";
import FilterService from "./src/FilterService";
import VendorService from "./src/VendorService";
import CacheService from "./src/CacheService";

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
    .service("FilterUpdateService", FilterUpdateService)
    .service("FilterService", FilterService);

export {
    ClassicalGuitarService,
    ElectricGuitarService,
    WesternGuitarService,
    FilterUpdateService,
    PendingTaskService,
    BassGuitarService,
    UrlParamResolver,
    GuitarResource,
    RoutingService,
    FilterService,
    VendorService,
    CacheService,
};

export default servicesModuleName;