import { ClassicalGuitar } from "../../../Models/models";

import { ControllerBase } from "../ControllerBase";

import {
    IGuitarService,
    IRoutingService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class ClassicalController extends ControllerBase<ClassicalGuitar> implements ng.IController {
    static $inject = ["ClassicalGuitarService", "RoutingService", "FilterUpdateService"];

    constructor(service: IGuitarService<ClassicalGuitar>, routingService: IRoutingService, private filterUpdateService: IFilterUpdateService) {
        super(service, routingService);
    }
}