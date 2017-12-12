import Guitar from "./Guitar";


export default class BassGuitar extends Guitar {
    stringNumber: 1 | 4 | 5 | 7 | 8 | 10;
    soundBox: "Single" | "Humbucker";

    stringNumbers(): (1 | 4 | 5 | 7 | 8 | 10)[] {
        return [1, 4, 5, 7, 8, 10];
    }

    soundBoxes(): ("Single" | "Humbucker")[] {
        return ["Single", "Humbucker"];
    }
}