﻿import {
    Price,
    Guitar,
    Vendor,
    Filter,
    GuitarFilter
} from "../../Models/models";

import { IService } from "../../Interfaces/interfaces";


export interface IGuitarService<TGuitar extends Guitar> extends IService {
    getGuitars(guitarFilter: GuitarFilter, lowerBound: number, upperBound: number, useCache: boolean): ng.IPromise<TGuitar[]>;

    getSortedGuitars(guitarFilter: GuitarFilter, lowerBound: number, upperBound: number, useCache: boolean): ng.IPromise<TGuitar[]>;

    getAmount(guitarFilter: GuitarFilter, useCache: boolean): ng.IPromise<number>;
}