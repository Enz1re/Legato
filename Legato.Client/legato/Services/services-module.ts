import angular from "angular";

import UrlParamResolverFactoryService from "./src/UrlParamResolverFactoryService"
import ClassicalGuitarService from "./src/ClassicalGuitarService";
import ElectricGuitarService from "./src/ElectricGuitarService";
import WesternGuitarService from "./src/WesternGuitarService";
import PendingTaskService from "./src/PendingTaskService";
import BassGuitarService from "./src/BassGuitarService";
import UrlParamResolver from "./src/UrlParamResolver";
import GuitarResource from "./src/GuitarResource";
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
    .service("UrlParamResolverFactoryService", UrlParamResolverFactoryService);

export {
    UrlParamResolverFactoryService,
    ClassicalGuitarService,
    ElectricGuitarService,
    WesternGuitarService,
    PendingTaskService,
    BassGuitarService,
    UrlParamResolver,
    GuitarResource,
    VendorService,
    CacheService,
};

export default servicesModuleName;