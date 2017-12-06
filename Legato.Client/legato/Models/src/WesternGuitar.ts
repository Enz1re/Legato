import Guitar from "./Guitar";


export default class WesternGuitar extends Guitar {
    stringNumber: 6 | 7 | 8 | 10 | 12;
    stringCaliber: 8 | 9 | 10 | 11 | 12 | 13;

    stringNumbers() {
        return [6, 7, 8, 10, 12];
    }

    stringCalibers() {
        return [8, 9, 10, 11, 12, 13];
    }
}