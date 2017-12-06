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
import { LoginDirective } from "./src/login/LoginDirective";
import { LegatoContextMenuDirective } from "./src/contextMenu/LegatoContextMenuDirective";
import { LegatoAdminPanelDirective } from "./src/admin/LegatoAdminPanelDirective";

import { MainController } from "./src/legato/MainController";
import { ClassicalController } from "./src/classical/ClassicalController";
import { WesternController } from "./src/western/WesternController";
import { ElectricController } from "./src/electric/ElectricController";
import { BassController } from "./src/bass/BassController";
import { ControllerBase } from "./src/ControllerBase";
import { GuitarModalController } from "./src/guitarModal/GuitarModalController";
import { LoginController } from "./src/login/LoginController";
import { LoginModalController } from "./src/login/LoginModalController";
import { AdminPanelController } from "./src/admin/AdminPanelController";
import { AddEditModalController } from "./src/guitarModal/AddEditModalController";
import { DisplayAmountModalController } from "./src/guitarModal/DisplayAmountModalController";
import { GuitarDeleteModalController } from "./src/guitarModal/GuitarDeleteModalController";

const directivesModuleName = "legato.components";

angular.module(directivesModuleName, [])
    // directive/component declarations
    .directive("legato", MainDirective.create())
    .directive("classical", ClassicalDirective.create())
    .directive("western", WesternDirective.create())
    .directive("electric", ElectricDirective.create())
    .directive("bass", BassDirective.create())
    .directive("legatoValidatePrice", LegatoValidatePriceDirective.create())
    .directive("legatoLoading", LegatoLoadingDirective.create())
    .directive("legatoSmoothScroll", LegatoSmoothScrollDirective.create())
    .directive("legatoRequestLoader", LegatoRequestLoaderDirective.create())
    .directive("login", LoginDirective.create())
    .directive("contextMenu", LegatoContextMenuDirective.create())
    .directive("adminPanel", LegatoAdminPanelDirective.create())
    // controller declarations
    .controller("MainController", MainController)
    .controller("ClassicalController", ClassicalController)
    .controller("WesternController", WesternController)
    .controller("ElectricController", ElectricController)
    .controller("BassController", BassController)
    .controller("GuitarModalController", GuitarModalController)
    .controller("LoginController", LoginController)
    .controller("LoginModalController", LoginModalController)
    .controller("AddEditModalController", AddEditModalController)
    .controller("DisplayAmountModalController", DisplayAmountModalController)
    .controller("GuitarDeleteModalController", GuitarDeleteModalController)
    .controller("AdminPanelController", AdminPanelController);

export {
    MainController,
    ControllerBase,
    ClassicalController,
    WesternController,
    ElectricController,
    BassController,
    LoginController
};

export default directivesModuleName;