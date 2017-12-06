import { WesternGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import {
    IModalService,
    IGuitarService,
    IRoutingService,
    IContextMenuService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class WesternController extends ControllerBase<WesternGuitar> implements ng.IController {
    static $inject = ["$rootScope", "WesternGuitarService", "RoutingService", "PendingTaskService", "FilterUpdateService", "ModalService", "ContextMenuService"];

    constructor($rootScope: ng.IRootScopeService, service: IGuitarService<WesternGuitar>, routingService: IRoutingService,
                pendingTaskService: IPendingTaskService, filterUpdateService: IFilterUpdateService, modalService: IModalService, contextMenu: IContextMenuService) {
        super($rootScope, service, routingService, pendingTaskService, filterUpdateService, modalService, contextMenu);
    }
}