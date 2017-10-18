export default class Vendor {
    name: string;
    selected: boolean;

    constructor(name: string, selected = true) {
        this.name = name;
        this.selected = selected;
    }
}