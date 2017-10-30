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
    const vendor = "Vendor";
    const price = "Price";
    const guitars: Guitar[] = [
        { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
        { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
        { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
        { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
        { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
        { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
        { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
        { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" },
    ];

    it("doesn"t sort an array when no property given", () => {
        const sortedTest = filter(guitars);
        compareArrays(guitars, sortedTest, vendor);
    });

    it("doesn"t sort an array when sorting by price with no direction given", () => {
        const sortedTest = filter(guitars, price);
        compareArrays(guitars, sortedTest, price);
    });

    it("sorts an array by vendor", () => {
        const sortedTest = filter(guitars, vendor);
        const sortedExact = [
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
        ];
        compareArrays(sortedExact, sortedTest, vendor);
    });

    it("sorts an array by price ascendingly", () => {
        const sortedTest = filter(guitars, price, ascending);
        const sortedExact = [
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
        ];
        compareArrays(sortedExact, sortedTest, price);
    });

    it("sorts an array by price descendingly", () => {
        const sortedTest = filter(guitars, price, descending);
        const sortedExact = [
            { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
        ];
        compareArrays(sortedExact, sortedTest, price);
    });
});