﻿import { ClassicalGuitar } from "../../../Models/models";

import { ControllerBase } from "../ControllerBase";

import {
    IModalService,
    IGuitarService,
    IPagingService,
    IRoutingService,
    IContextMenuService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class ClassicalController extends ControllerBase<ClassicalGuitar> implements ng.IController {
    static $inject = ["$rootScope", "ClassicalGuitarService", "RoutingService", "PendingTaskService", "FilterUpdateService", "ModalService", "ContextMenuService", "PagingService"];

    constructor($rootScope: ng.IRootScopeService, service: IGuitarService<ClassicalGuitar>, routingService: IRoutingService, pendingTaskService: IPendingTaskService,
                filterUpdateService: IFilterUpdateService, modalService: IModalService, contextMenu: IContextMenuService, pagingService: IPagingService) {
        super($rootScope, service, routingService, pendingTaskService, filterUpdateService, modalService, contextMenu, pagingService);
    }
}