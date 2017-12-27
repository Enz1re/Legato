﻿import { BassGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import {
    IUserService,
    IModalService,
    IGuitarService,
    IPagingService,
    IUpdateService,
    IRoutingService,
    IContextMenuService,
    IPendingTaskService,
} from "../../../Interfaces/interfaces";


export class BassController extends ControllerBase<BassGuitar> implements ng.IController {
    static $inject = ["$scope", "BassGuitarService", "RoutingService", "PendingTaskService", "UpdateService",
                      "ModalService", "ContextMenuService", "PagingService", "UserService"];

    constructor($scope: ng.IScope, service: IGuitarService<BassGuitar>, routingService: IRoutingService, pendingTaskService: IPendingTaskService,
                updateService: IUpdateService, modalService: IModalService, contextMenu: IContextMenuService, pagingService: IPagingService, userService: IUserService) {
        super($scope, service, routingService, pendingTaskService, updateService, modalService, contextMenu, pagingService, userService);
    }
}