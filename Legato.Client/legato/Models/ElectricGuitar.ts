import Guitar from './Guitar';

export default class ElectricGuitar extends Guitar {
    StringNumber: 6 | 7 | 8 | 10 | 12;
    HasTremoloBar: boolean;
    SoundBox: "Single" | "Humbucker";
    StringCaliber: 8 | 9 | 10 | 11 | 12 | 13;
}