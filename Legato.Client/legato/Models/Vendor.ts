export class Vendor {
    name: string;
    selected: boolean;

    constructor(name: string, selected = false) {
        this.name = name;
        this.selected = selected;
    }
}