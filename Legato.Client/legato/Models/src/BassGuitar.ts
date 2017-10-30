import Guitar from "./Guitar";


export default class BassGuitar extends Guitar {
    StringNumber: 1 | 4 | 5 | 7 | 8 | 10;
    SoundBox: "Single" | "Humbucker";
}