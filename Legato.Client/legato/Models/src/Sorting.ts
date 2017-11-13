export default class Sorting {
    required: boolean = false;
    name: "Vendor" | "Price";
    direction: "Ascending" | "Descending";

    constructor(init?: Partial<Sorting>) {
        Object.assign(this, init);
        this.name = init ? init.name : "Vendor";
        this.direction = init ? init.direction : "Ascending";
    }
}