import { WesternGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import {
    IModalService,
    IGuitarService,
    IRoutingService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class WesternController extends ControllerBase<WesternGuitar> implements ng.IController {
    static $inject = ["$scope", "WesternGuitarService", "RoutingService", "PendingTaskService", "FilterUpdateService", "ModalService"];

    constructor($scope: ng.IScope, service: IGuitarService<WesternGuitar>, routingService: IRoutingService,
                pendingTaskService: IPendingTaskService, filterUpdateService: IFilterUpdateService, modalService: IModalService) {
        super($scope, service, routingService, pendingTaskService, filterUpdateService, modalService);
    }
}