import angular from "angular";

import ClassicalGuitarService from "./src/ClassicalGuitarService";
import WesternGuitarService from "./src/WesternGuitarService";
import ElectricGuitarService from "./src/ElectricGuitarService";
import BassGuitarService from "./src/BassGuitarService";
import GuitarResource from "./src/GuitarResource";
import VendorService from "./src/VendorService";
import CacheService from "./src/CacheService";

const servicesModuleName = "legato.services";

angular.module(servicesModuleName, [])
    .service("ClassicalGuitarService", ClassicalGuitarService)
    .service("WesternGuitarService", WesternGuitarService)
    .service("ElectricGuitarService", ElectricGuitarService)
    .service("BassGuitarService", BassGuitarService)
    .service("GuitarResource", GuitarResource)
    .service("VendorService", VendorService)
    .service("CacheService", CacheService);

export {
    ClassicalGuitarService,
    ElectricGuitarService,
    WesternGuitarService,
    BassGuitarService,
    GuitarResource,
    VendorService,
    CacheService,
};

export default servicesModuleName;