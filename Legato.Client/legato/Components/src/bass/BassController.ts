import { BassGuitar } from "../../../Models/models"

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


export class BassController extends ControllerBase<BassGuitar> implements ng.IController {
    static $inject = ["$rootScope", "BassGuitarService", "RoutingService", "PendingTaskService", "UpdateService", "ModalService", "ContextMenuService", "PagingService"];

    constructor($rootScope: ng.IRootScopeService, service: IGuitarService<BassGuitar>, routingService: IRoutingService, pendingTaskService: IPendingTaskService,
                updateService: IUpdateService, modalService: IModalService, contextMenu: IContextMenuService, pagingService: IPagingService) {
        super($rootScope, service, routingService, pendingTaskService, updateService, modalService, contextMenu, pagingService);
    }
}