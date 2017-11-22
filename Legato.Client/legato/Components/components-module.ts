import angular from "angular";

import { MainDirective } from "./src/legato/MainDirective";
import { ClassicalDirective } from "./src/classical/ClassicalDirective";
import { WesternDirective } from "./src/western/WesternDirective";
import { ElectricDirective } from "./src/electric/ElectricDirective";
import { BassDirective } from "./src/bass/BassDirective";
import { LegatoValidatePriceDirective } from "./src/validatePrice/LegatoValidatePriceDirective";
import { LegatoLoadingDirective } from "./src/loading/LegatoLoadingDirective";
import { LegatoSmoothScrollDirective } from "./src/smoothScroll/LegatoSmoothScrollDirective";
import { LegatoRequestLoaderDirective } from "./src/loading/LegatoRequestLoaderDirective";

import { MainController } from "./src/legato/MainController";
import { ClassicalController } from "./src/classical/ClassicalController";
import { WesternController } from "./src/western/WesternController";
import { ElectricController } from "./src/electric/ElectricController";
import { BassController } from "./src/bass/BassController";
import { ControllerBase } from "./src/ControllerBase";

const directivesModuleName = "legato.components";

angular.module(directivesModuleName, [])
    // directive declarations
    .directive("legato", MainDirective.create())
    .directive("classical", ClassicalDirective.create())
    .directive("western", WesternDirective.create())
    .directive("electric", ElectricDirective.create())
    .directive("bass", BassDirective.create())
    .directive("legatoValidatePrice", LegatoValidatePriceDirective.create())
    .directive("legatoLoading", LegatoLoadingDirective.create())
    .directive("legatoSmoothScroll", LegatoSmoothScrollDirective.create())
    .directive("legatoRequestLoader", LegatoRequestLoaderDirective.create())
    // controller declarations
    .controller("MainController", MainController)
    .controller("ClassicalController", ClassicalController)
    .controller("WesternController", WesternController)
    .controller("ElectricController", ElectricController)
    .controller("BassController", BassController);

export {
    MainController,
    ControllerBase,
    ClassicalController,
    WesternController,
    ElectricController,
    BassController
};

export default directivesModuleName;