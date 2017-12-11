import { ClassicalGuitar } from "../../../Models/models";

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


export class ClassicalController extends ControllerBase<ClassicalGuitar> implements ng.IController {
    static $inject = ["$rootScope", "ClassicalGuitarService", "RoutingService", "PendingTaskService", "UpdateService", "ModalService", "ContextMenuService", "PagingService"];

    constructor($rootScope: ng.IRootScopeService, service: IGuitarService<ClassicalGuitar>, routingService: IRoutingService, pendingTaskService: IPendingTaskService,
                updateService: IUpdateService, modalService: IModalService, contextMenu: IContextMenuService, pagingService: IPagingService) {
        super($rootScope, service, routingService, pendingTaskService, updateService, modalService, contextMenu, pagingService);
    }
}