import { BassGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import {
    IModalService,
    IGuitarService,
    IRoutingService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class BassController extends ControllerBase<BassGuitar> implements ng.IController {
    static $inject = ["$scope", "BassGuitarService", "RoutingService", "PendingTaskService", "FilterUpdateService", "ModalService"];

    constructor($scope: ng.IScope, service: IGuitarService<BassGuitar>, routingService: IRoutingService,
                pendingTaskService: IPendingTaskService, filterUpdateService: IFilterUpdateService, modalService: IModalService) {
        super($scope, service, routingService, pendingTaskService, filterUpdateService, modalService);
    }
}