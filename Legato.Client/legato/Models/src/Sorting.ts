export default class Sorting {
    required: boolean = false;
    name: "Vendor" | "Price";
    direction: "Ascending" | "Descending";

    constructor() {
        this.name = "Vendor";
        this.direction = "Ascending";
    }
}