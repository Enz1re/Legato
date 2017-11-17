import { ElectricGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import {
    IGuitarService,
    IRoutingService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class ElectricController extends ControllerBase<ElectricGuitar> implements ng.IController {
    static $inject = ["ElectricGuitarService", "RoutingService", "FilterUpdateService"];

    constructor(service: IGuitarService<ElectricGuitar>, routingService: IRoutingService) {
        super(service, routingService);
    }
}