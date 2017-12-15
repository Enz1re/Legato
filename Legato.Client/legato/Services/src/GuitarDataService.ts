import { IGuitarDataService } from "../../Interfaces/interfaces";


export default class GuitarDataService implements IGuitarDataService {
    data: {
        classical: {
            stringTypes: string[]
        },
        western: {
            stringNumbers: number[]
            stringCalibers: number[]
        },
        electric: {
            stringNumbers: number[]
            soundBoxes: string[]
            stringCalibers: number[]
        },
        bass: {
            stringNumbers: number[]
            soundBoxes: string[]
        }
    }

    constructor(/* Place here a service to get validation values of guitars' data */) {
        const classical = {
            stringTypes: ["Nylon", "Fluorocarbon"]
        };
        const western = {
            stringNumbers: [6, 7, 8, 10, 12],
            stringCalibers: [8, 9, 10, 11, 12, 13]
        };
        const electric = {
            stringNumbers: [6, 7, 8, 10, 12],
            soundBoxes: ["Single", "Humbucker"],
            stringCalibers: [8, 9, 10, 11, 12, 13]
        };
        const bass = {
            stringNumbers: [1, 4, 5, 7, 8, 10],
            soundBoxes: ["Single", "Humbucker"]
        };

        this.data = {
            classical: classical,
            western: western,
            electric: electric,
            bass: bass
        };
    }
}