import { WesternGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import {
    IModalService,
    IGuitarService,
    IPagingService,
    IUpdateService,
    IRoutingService,
    IContextMenuService,
    IPendingTaskService,
} from "../../../Interfaces/interfaces";


export class WesternController extends ControllerBase<WesternGuitar> implements ng.IController {
    static $inject = ["$rootScope", "WesternGuitarService", "RoutingService", "PendingTaskService", "UpdateService", "ModalService", "ContextMenuService", "PagingService"];

    constructor($rootScope: ng.IRootScopeService, service: IGuitarService<WesternGuitar>, routingService: IRoutingService, pendingTaskService: IPendingTaskService,
                updateService: IUpdateService, modalService: IModalService, contextMenu: IContextMenuService, pagingService: IPagingService) {
        super($rootScope, service, routingService, pendingTaskService, updateService, modalService, contextMenu, pagingService);
    }
}