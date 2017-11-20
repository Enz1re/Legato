import { WesternGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import {
    IGuitarService,
    IRoutingService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class WesternController extends ControllerBase<WesternGuitar> implements ng.IController {
    static $inject = ["$scope", "WesternGuitarService", "RoutingService", "PendingTaskService", "FilterUpdateService"];

    constructor($scope: ng.IScope, service: IGuitarService<WesternGuitar>, routingService: IRoutingService,
        pendingTaskService: IPendingTaskService, filterUpdateService: IFilterUpdateService) {
        super($scope, service, routingService, pendingTaskService, filterUpdateService);
    }
}