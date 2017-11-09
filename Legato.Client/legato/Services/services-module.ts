import angular from "angular";

import ClassicalGuitarService from "./src/ClassicalGuitarService";
import ElectricGuitarService from "./src/ElectricGuitarService";
import WesternGuitarService from "./src/WesternGuitarService";
import LoadOnChangeService from "./src/LoadOnChangeService";
import BassGuitarService from "./src/BassGuitarService";
import GuitarResource from "./src/GuitarResource";
import VendorService from "./src/VendorService";
import CacheService from "./src/CacheService";

const servicesModuleName = "legato.services";

angular.module(servicesModuleName, [])
    .service("ClassicalGuitarService", ClassicalGuitarService)
    .service("ElectricGuitarService", ElectricGuitarService)
    .service("WesternGuitarService", WesternGuitarService)
    .service("LoadOnChangeService", LoadOnChangeService)
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