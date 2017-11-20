import { ClassicalGuitar } from "../../../Models/models";

import { ControllerBase } from "../ControllerBase";

import {
    IGuitarService,
    IRoutingService,
    IPendingTaskService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class ClassicalController extends ControllerBase<ClassicalGuitar> implements ng.IController {
    static $inject = ["$scope", "ClassicalGuitarService", "RoutingService", "PendingTaskService", "FilterUpdateService"];

    constructor($scope: ng.IScope, service: IGuitarService<ClassicalGuitar>, routingService: IRoutingService,
                pendingTaskService: IPendingTaskService, filterUpdateService: IFilterUpdateService) {
        super($scope, service, routingService, pendingTaskService, filterUpdateService);
    }
}