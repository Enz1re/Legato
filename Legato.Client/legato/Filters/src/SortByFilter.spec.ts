import sortByFilter from "./SortByFilter";
import { Guitar } from "../../Models/models";


function compareArrays(sample: Guitar[], test: Guitar[], prop: string) {
    expect(sample.length).toBe(test.length);
    const sampleList = sample.map(g => g[prop]);
    const testList = test.map(g => g[prop]);
    sampleList.forEach(price => expect(testList).toContain(price));
}


describe("SortByFilter", () => {
    const filter = sortByFilter();
    const ascending = "Ascending";
    const descending = "Descending";
    const vendor = "vendor";
    const price = "price";
    const guitars: Guitar[] = [
        { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 1211, imgPath: "" },
        { vendor: { name: "Rogue", isSelected: true }, model: "", mensura: 0, price: 988, imgPath: "" },
        { vendor: { name: "B.C. Rich", isSelected: true }, model: "", mensura: 0, price: 1653, imgPath: "" },
        { vendor: { name: "Mitchell", isSelected: true }, model: "", mensura: 0, price: 3673, imgPath: "" },
        { vendor: { name: "Kremona", isSelected: true }, model: "", mensura: 0, price: 10233, imgPath: "" },
        { vendor: { name: "Lucero", isSelected: true }, model: "", mensura: 0, price: 20101, imgPath: "" },
        { vendor: { name: "Friedman", isSelected: true }, model: "", mensura: 0, price: 6111, imgPath: "" },
        { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 3880, imgPath: "" },
    ];

    it("doesn't sort an array when no property given", () => {
        const sortedTest = filter(guitars);
        compareArrays(guitars, sortedTest, vendor);
    });

    it("doesn't sort an array when sorting by price with no direction given", () => {
        const sortedTest = filter(guitars, price);
        compareArrays(guitars, sortedTest, price);
    });

    it("sorts an array by vendor", () => {
        const sortedTest = filter(guitars, vendor);
        const sortedExact = [
            { vendor: { name: "B.C. Rich", isSelected: true }, model: "", mensura: 0, price: 1653, imgPath: "" },
            { vendor: { name: "Friedman", isSelected: true }, model: "", mensura: 0, price: 6111, imgPath: "" },
            { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 3880, imgPath: "" },
            { vendor: { name: "Kremona", isSelected: true }, model: "", mensura: 0, price: 10233, imgPath: "" },
            { vendor: { name: "Lucero", isSelected: true }, model: "", mensura: 0, price: 20101, imgPath: "" },
            { vendor: { name: "Mitchell", isSelected: true }, model: "", mensura: 0, price: 3673, imgPath: "" },
            { vendor: { name: "Rogue", isSelected: true }, model: "", mensura: 0, price: 988, imgPath: "" },
            { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 1211, imgPath: "" },
        ];
        compareArrays(sortedExact, sortedTest, vendor);
    });

    it("sorts an array by price ascendingly", () => {
        const sortedTest = filter(guitars, price, ascending);
        const sortedExact = [
            { vendor: { name: "Rogue", isSelected: true }, model: "", mensura: 0, price: 988, imgPath: "" },
            { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 1211, imgPath: "" },
            { vendor: { name: "B.C. Rich", isSelected: true }, model: "", mensura: 0, price: 1653, imgPath: "" },
            { vendor: { name: "Mitchell", isSelected: true }, model: "", mensura: 0, price: 3673, imgPath: "" },
            { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 3880, imgPath: "" },
            { vendor: { name: "Friedman", isSelected: true }, model: "", mensura: 0, price: 6111, imgPath: "" },
            { vendor: { name: "Kremona", isSelected: true }, model: "", mensura: 0, price: 10233, imgPath: "" },
            { vendor: { name: "Lucero", isSelected: true }, model: "", mensura: 0, price: 20101, imgPath: "" },
        ];
        compareArrays(sortedExact, sortedTest, price);
    });

    it("sorts an array by price descendingly", () => {
        const sortedTest = filter(guitars, price, descending);
        const sortedExact = [
            { vendor: { name: "Lucero", isSelected: true }, model: "", mensura: 0, price: 20101, imgPath: "" },
            { vendor: { name: "Kremona", isSelected: true }, model: "", mensura: 0, price: 10233, imgPath: "" },
            { vendor: { name: "Friedman", isSelected: true }, model: "", mensura: 0, price: 6111, imgPath: "" },
            { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 3880, imgPath: "" },
            { vendor: { name: "Mitchell", isSelected: true }, model: "", mensura: 0, price: 3673, imgPath: "" },
            { vendor: { name: "B.C. Rich", isSelected: true }, model: "", mensura: 0, price: 1653, imgPath: "" },
            { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 1211, imgPath: "" },
            { vendor: { name: "Rogue", isSelected: true }, model: "", mensura: 0, price: 988, imgPath: "" },
        ];
        compareArrays(sortedExact, sortedTest, price);
    });
});