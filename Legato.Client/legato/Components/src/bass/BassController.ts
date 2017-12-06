import { BassGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import {
    IModalService,
    IGuitarService,
    IRoutingService,
    IContextMenuService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class BassController extends ControllerBase<BassGuitar> implements ng.IController {
    static $inject = ["$rootScope", "BassGuitarService", "RoutingService", "PendingTaskService", "FilterUpdateService", "ModalService", "ContextMenuService"];

    constructor($rootScope: ng.IRootScopeService, service: IGuitarService<BassGuitar>, routingService: IRoutingService,
                pendingTaskService: IPendingTaskService, filterUpdateService: IFilterUpdateService, modalService: IModalService, contextMenu: IContextMenuService) {
        super($rootScope, service, routingService, pendingTaskService, filterUpdateService, modalService, contextMenu);
    }
}