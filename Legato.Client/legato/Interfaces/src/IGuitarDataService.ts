export interface IGuitarDataService {
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
}