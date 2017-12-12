import Guitar from "./Guitar";


export default class ElectricGuitar extends Guitar {
    stringNumber: 6 | 7 | 8 | 10 | 12;
    hasTremoloBar: boolean;
    soundBox: "Single" | "Humbucker";
    stringCaliber: 8 | 9 | 10 | 11 | 12 | 13;

    stringNumbers(): (6 | 7 | 8 | 10 | 12)[] {
        return [6, 7, 8, 10, 12];
    }

    soundBoxes(): ("Single" | "Humbucker")[] {
        return ["Single", "Humbucker"];
    }

    stringCalibers(): (8 | 9 | 10 | 11 | 12 | 13)[] {
        return [8, 9, 10, 11, 12, 13];
    }
}