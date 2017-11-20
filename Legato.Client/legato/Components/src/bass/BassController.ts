import { BassGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import {
    IGuitarService,
    IRoutingService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class BassController extends ControllerBase<BassGuitar> implements ng.IController {
    static $inject = ["$scope", "BassGuitarService", "RoutingService", "PendingTaskService", "FilterUpdateService"];

    constructor($scope: ng.IScope, service: IGuitarService<BassGuitar>, routingService: IRoutingService,
        pendingTaskService: IPendingTaskService, filterUpdateService: IFilterUpdateService) {
        super($scope, service, routingService, pendingTaskService, filterUpdateService);
    }
}