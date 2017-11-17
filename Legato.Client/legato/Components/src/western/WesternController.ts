import { WesternGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import {
    IGuitarService,
    IRoutingService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class WesternController extends ControllerBase<WesternGuitar> implements ng.IController {
    static $inject = ["WesternGuitarService", "RoutingService", "FilterUpdateService"];

    constructor(service: IGuitarService<WesternGuitar>, routingService: IRoutingService) {
        super(service, routingService);
    }
}