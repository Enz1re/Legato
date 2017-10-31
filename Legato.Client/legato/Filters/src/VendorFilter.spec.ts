import vendorFilter from "./VendorFilter";
import { Guitar } from "../../Models/models";


function compareArrays(sample: Guitar[], test: Guitar[]) {
    expect(sample.length).toBe(test.length);
    const sampleList = sample.map(g => g.vendor.name);
    const testList = test.map(g => g.vendor.name);
    sampleList.forEach(v => expect(testList).toContain(v));
}


describe("VendorFilter", () => {
    const filter = vendorFilter();
    const guitars: Guitar[] = [
        { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 1211, imgPath: "" },
        { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 988, imgPath: "" },
        { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 1653, imgPath: "" },
        { vendor: { name: "Mitchell", isSelected: true }, model: "", mensura: 0, price: 3673, imgPath: "" },
        { vendor: { name: "Kremona", isSelected: true }, model: "", mensura: 0, price: 10233, imgPath: "" },
        { vendor: { name: "Lucero", isSelected: true }, model: "", mensura: 0, price: 20101, imgPath: "" },
        { vendor: { name: "Friedman", isSelected: true }, model: "", mensura: 0, price: 6111, imgPath: "" },
        { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 3880, imgPath: "" },
        { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 1211, imgPath: "" },
        { vendor: { name: "Rogue", isSelected: true }, model: "", mensura: 0, price: 3333, imgPath: "" },
        { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 1000, imgPath: "" },
        { vendor: { name: "Mitchell", isSelected: true }, model: "", mensura: 0, price: 3673, imgPath: "" },
        { vendor: { name: "Kremona", isSelected: true }, model: "", mensura: 0, price: 7488, imgPath: "" },
        { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 33101, imgPath: "" },
        { vendor: { name: "Friedman", isSelected: true }, model: "", mensura: 0, price: 6112, imgPath: "" },
        { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 11111, imgPath: "" }
    ];

    it("returns no records for vendor B.C. Rich", () => {
        const filteredTest = filter(guitars, ["B.C. Rich"]);
        const filteredExact = [];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns no records for vendor The Loar", () => {
        const filteredTest = filter(guitars, ["The Loar"]);
        const filteredExact = [];
        compareArrays([], filteredTest);
    });

    it("returns no records for vendors B.C. Rich, The Loar", () => {
        const filteredTest = filter(guitars, ["B.C. Rich", "The Loar"]);
        const filteredExact = [];
        compareArrays([], filteredTest);
    });

    it("returns one record for vendor Lucero", () => {
        const filteredTest = filter(guitars, ["Lucero"]);
        const filteredExact = [
            { vendor: { name: "Lucero", isSelected: true }, model: "", mensura: 0, price: 20101, imgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns one record for vendor Rogue", () => {
        const filteredTest = filter(guitars, ["Rogue"]);
        const filteredExact = [
            { vendor: { name: "Rogue", isSelected: true }, model: "", mensura: 0, price: 3333, imgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records for vendors Lucero, Rogue", () => {
        const filteredTest = filter(guitars, ["Lucero", "Rogue"]);
        const filteredExact = [
            { vendor: { name: "Lucero", isSelected: true }, model: "", mensura: 0, price: 20101, imgPath: "" },
            { vendor: { name: "Rogue", isSelected: true }, model: "", mensura: 0, price: 3333, imgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns four records for vendor Yamaha", () => {
        const filteredTest = filter(guitars, ["Yamaha"]);
        const filteredExact = [
            { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 1211, imgPath: "" },
            { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 988, imgPath: "" },
            { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 1211, imgPath: "" },
            { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 33101, imgPath: "" },
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns six records for vendors Lucero, Rogue, Yamaha", () => {
        const filteredTest = filter(guitars, ["Lucero", "Rogue", "Yamaha"]);
        const filteredExact = [
            { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 1211, imgPath: "" },
            { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 988, imgPath: "" },
            { vendor: { name: "Lucero", isSelected: true }, model: "", mensura: 0, price: 20101, imgPath: "" },
            { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 1211, imgPath: "" },
            { vendor: { name: "Rogue", isSelected: true }, model: "", mensura: 0, price: 3333, imgPath: "" },
            { vendor: { name: "Yamaha", isSelected: true }, model: "", mensura: 0, price: 33101, imgPath: "" },
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records for vendor Mitchell", () => {
        const filteredTest = filter(guitars, ["Mitchell"]);
        const filteredExact = [
            { vendor: { name: "Mitchell", isSelected: true }, model: "", mensura: 0, price: 3673, imgPath: "" },
            { vendor: { name: "Mitchell", isSelected: true }, model: "", mensura: 0, price: 3673, imgPath: "" },
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns four records for vendor Hofner", () => {
        const filteredTest = filter(guitars, ["Hofner"]);
        const filteredExact = [
            { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 1653, imgPath: "" },
            { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 3880, imgPath: "" },
            { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 1000, imgPath: "" },
            { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 11111, imgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records for vendor Kremona", () => {
        const filteredTest = filter(guitars, ["Kremona"]);
        const filteredExact = [
            { vendor: { name: "Kremona", isSelected: true }, model: "", mensura: 0, price: 10233, imgPath: "" },
            { vendor: { name: "Kremona", isSelected: true }, model: "", mensura: 0, price: 7488, imgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns eight records for vendors Mitchell, Hofner, Kremona", () => {
        const filteredTest = filter(guitars, ["Mitchell", "Hofner", "Kremona"]);
        const filteredExact = [
            { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 1653, imgPath: "" },
            { vendor: { name: "Mitchell", isSelected: true }, model: "", mensura: 0, price: 3673, imgPath: "" },
            { vendor: { name: "Kremona", isSelected: true }, model: "", mensura: 0, price: 10233, imgPath: "" },
            { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 3880, imgPath: "" },
            { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 1000, imgPath: "" },
            { vendor: { name: "Mitchell", isSelected: true }, model: "", mensura: 0, price: 3673, imgPath: "" },
            { vendor: { name: "Kremona", isSelected: true }, model: "", mensura: 0, price: 7488, imgPath: "" },
            { vendor: { name: "Hofner", isSelected: true }, model: "", mensura: 0, price: 11111, imgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns sixteen records for vendors Yamaha, Hofner, Mitchell, Kremona, Lucero, Friedman, Rogue", () => {
        const filteredTest = filter(guitars, ["Yamaha", "Hofner", "Mitchell", "Kremona", "Lucero", "Friedman", "Rogue"]);
        compareArrays(guitars, filteredTest);
    });
});