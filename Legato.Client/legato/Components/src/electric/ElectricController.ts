import { ElectricGuitar } from "../../../Models/models"

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


export class ElectricController extends ControllerBase<ElectricGuitar> implements ng.IController {
    static $inject = ["$scope", "ElectricGuitarService", "RoutingService", "PendingTaskService", "UpdateService",
                      "ModalService", "ContextMenuService", "PagingService", "ClaimService"];

    constructor($scope: ng.IScope, service: IGuitarService<ElectricGuitar>, routingService: IRoutingService, pendingTaskService: IPendingTaskService,
                updateService: IUpdateService, modalService: IModalService, contextMenu: IContextMenuService, pagingService: IPagingService, claimService: IClaimService) {
        super($scope, service, routingService, pendingTaskService, updateService, modalService, contextMenu, pagingService, claimService);
    }
}