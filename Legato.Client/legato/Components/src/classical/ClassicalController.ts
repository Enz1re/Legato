import { ClassicalGuitar } from "../../../Models/models";

import { ControllerBase } from "../ControllerBase";

import {
    IClaimService,
    IModalService,
    IGuitarService,
    IPagingService,
    IUpdateService,
    IRoutingService,
    IContextMenuService,
    IPendingTaskService,
} from "../../../Interfaces/interfaces";


export class ClassicalController extends ControllerBase<ClassicalGuitar> implements ng.IController {
    static $inject = ["$scope", "ClassicalGuitarService", "RoutingService", "PendingTaskService", "UpdateService",
                      "ModalService", "ContextMenuService", "PagingService", "ClaimService"];

    constructor($scope: ng.IScope, service: IGuitarService<ClassicalGuitar>, routingService: IRoutingService, pendingTaskService: IPendingTaskService,
                updateService: IUpdateService, modalService: IModalService, contextMenu: IContextMenuService, pagingService: IPagingService, claimService: IClaimService) {
        super($scope, service, routingService, pendingTaskService, updateService, modalService, contextMenu, pagingService, claimService);
    }
}