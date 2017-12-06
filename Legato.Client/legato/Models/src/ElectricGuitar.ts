import Guitar from "./Guitar";


export default class ElectricGuitar extends Guitar {
    stringNumber: 6 | 7 | 8 | 10 | 12;
    hasTremoloBar: boolean;
    soundBox: "Single" | "Humbucker";
    stringCaliber: 8 | 9 | 10 | 11 | 12 | 13;

    stringNumbers() {
        return [6, 7, 8, 10, 12];
    }

    soundBoxes() {
        return ["Single", "Humbucker"];
    }

    stringCalibers() {
        return [8, 9, 10, 11, 12, 13];
    }
}