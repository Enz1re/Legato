import Guitar from "./Guitar";


export default class BassGuitar extends Guitar {
    stringNumber: 1 | 4 | 5 | 7 | 8 | 10;
    soundBox: "Single" | "Humbucker";

    stringNumbers() {
        return [1, 4, 5, 7, 8, 10];
    }

    soundBoxes() {
        return ["Single", "Humbucker"];
    }
}