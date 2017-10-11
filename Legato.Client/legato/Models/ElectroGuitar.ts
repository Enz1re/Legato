import Guitar from './Guitar';

export default class ElectroGuitar extends Guitar {
    stringNumber: 6 | 7 | 8 | 10 | 12;
    hasTremoloBar: boolean;
    soundBox: "Single" | "Humbucker";
    stringCaliber: 8 | 9 | 10 | 11 | 12 | 13;
}