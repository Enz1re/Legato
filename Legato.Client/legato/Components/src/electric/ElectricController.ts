import { ElectricGuitar } from "../../../Models/models"

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


export class ElectricController extends ControllerBase<ElectricGuitar> implements ng.IController {
    static $inject = ["$rootScope", "ElectricGuitarService", "RoutingService", "PendingTaskService", "UpdateService", "ModalService", "ContextMenuService", "PagingService"];

    constructor($rootScope: ng.IRootScopeService, service: IGuitarService<ElectricGuitar>, routingService: IRoutingService, pendingTaskService: IPendingTaskService,
                updateService: IUpdateService, modalService: IModalService, contextMenu: IContextMenuService, pagingService: IPagingService) {
        super($rootScope, service, routingService, pendingTaskService, updateService, modalService, contextMenu, pagingService);
    }
}