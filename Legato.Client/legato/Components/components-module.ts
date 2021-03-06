﻿import angular from "angular";

import { MainDirective } from "./src/legato/MainDirective";
import { ClassicalDirective } from "./src/classical/ClassicalDirective";
import { WesternDirective } from "./src/western/WesternDirective";
import { ElectricDirective } from "./src/electric/ElectricDirective";
import { BassDirective } from "./src/bass/BassDirective";
import { LegatoValidatePriceDirective } from "./src/validatePrice/LegatoValidatePriceDirective";
import { LegatoLoadingDirective } from "./src/loading/LegatoLoadingDirective";
import { LegatoSmoothScrollDirective } from "./src/smoothScroll/LegatoSmoothScrollDirective";
import { LegatoRequestLoaderDirective } from "./src/loading/LegatoRequestLoaderDirective";
import { LegatoContextMenuDirective } from "./src/contextMenu/LegatoContextMenuDirective";
import { LegatoAdminPanelDirective } from "./src/admin/LegatoAdminPanelDirective";
import { LegatoLoadOnScrollDirective } from "./src/loadOnScroll/LegatoLoadOnScrollDirective";
import { LegatoTopPanelDirective } from "./src/topPanel/LegatoTopPanelDirective";
import { LegatoFilterPanelDirective } from "./src/filterPanel/LegatoFilterPanelDirective";
import { LegatoTabPanelDirective } from "./src/tabPanel/LegatoTabPanelDirective";
import { LegatoVendorDirective } from "./src/vendorPanel/LegatoVendorDirective";
import { LegatoPaginationDirective } from "./src/legatoPagination/LegatoPaginationDirective";

import { MainController } from "./src/legato/MainController";
import { ClassicalController } from "./src/classical/ClassicalController";
import { WesternController } from "./src/western/WesternController";
import { ElectricController } from "./src/electric/ElectricController";
import { BassController } from "./src/bass/BassController";
import { ControllerBase } from "./src/ControllerBase";
import { CompromisedAttemptsController } from "./src/attemptModal/CompromisedAttemptsController";
import { GuitarModalController } from "./src/guitarModal/GuitarModalController";
import { LoginModalController } from "./src/login/LoginModalController";
import { AdminPanelController } from "./src/admin/AdminPanelController";
import { AddEditModalController } from "./src/guitarModal/AddEditModalController";
import { DisplayAmountModalController } from "./src/guitarModal/DisplayAmountModalController";
import { YesNoModalController } from "./src/guitarModal/YesNoModalController";
import { AlertModalController } from "./src/guitarModal/AlertModalController";
import { UserModalController } from "./src/userModal/UserModalController";
import { PaginationController } from "./src/legatoPagination/PaginationController";

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
    .directive("contextMenu", LegatoContextMenuDirective.create())
    .directive("adminPanel", LegatoAdminPanelDirective.create())
    .directive("loadOnScroll", LegatoLoadOnScrollDirective.create())
    .directive("topPanel", LegatoTopPanelDirective.create())
    .directive("filterPanel", LegatoFilterPanelDirective.create())
    .directive("tabPanel", LegatoTabPanelDirective.create())
    .directive("vendorPanel", LegatoVendorDirective.create())
    .directive("legatoPagination", LegatoPaginationDirective.create())
    // controller declarations
    .controller("MainController", MainController)
    .controller("ClassicalController", ClassicalController)
    .controller("WesternController", WesternController)
    .controller("ElectricController", ElectricController)
    .controller("BassController", BassController)
    .controller("GuitarModalController", GuitarModalController)
    .controller("LoginModalController", LoginModalController)
    .controller("AddEditModalController", AddEditModalController)
    .controller("DisplayAmountModalController", DisplayAmountModalController)
    .controller("YesNoModalController", YesNoModalController)
    .controller("AdminPanelController", AdminPanelController)
    .controller("AlertModalController", AlertModalController)
    .controller("UserModalController", UserModalController)
    .controller("CompromisedAttemptsController", CompromisedAttemptsController)
    .controller("PaginationController", PaginationController);

export {
    MainController,
    ControllerBase,
    ClassicalController,
    WesternController,
    ElectricController,
    BassController,
};

export default directivesModuleName;