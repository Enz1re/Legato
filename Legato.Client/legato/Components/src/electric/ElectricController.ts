import { ElectricGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import {
    IModalService,
    IGuitarService,
    IRoutingService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class ElectricController extends ControllerBase<ElectricGuitar> implements ng.IController {
    static $inject = ["$scope", "ElectricGuitarService", "RoutingService", "PendingTaskService", "FilterUpdateService", "ModalService"];

    constructor($scope: ng.IScope, service: IGuitarService<ElectricGuitar>, routingService: IRoutingService,
                pendingTaskService: IPendingTaskService, filterUpdateService: IFilterUpdateService, modalService: IModalService) {
        super($scope, service, routingService, pendingTaskService, filterUpdateService, modalService);
    }
}