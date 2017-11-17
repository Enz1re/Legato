import { BassGuitar } from "../../../Models/models"

import { ControllerBase } from "../ControllerBase";

import {
    IGuitarService,
    IRoutingService,
    IFilterUpdateService
} from "../../../Interfaces/interfaces";


export class BassController extends ControllerBase<BassGuitar> implements ng.IController {
    static $inject = ["BassGuitarService", "RoutingService", "FilterUpdateService"];

    constructor(service: IGuitarService<BassGuitar>, routingService: IRoutingService) {
        super(service, routingService);
    }
}