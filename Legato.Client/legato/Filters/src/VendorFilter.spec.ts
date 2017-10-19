import vendorFilter from './VendorFilter';
import Guitar from '../../Models/Guitar';


function compareArrays(sample: Guitar[], test: Guitar[]) {
    expect(sample.length).toBe(test.length);
    const sampleList = sample.map(g => g.Vendor);
    const testList = test.map(g => g.Vendor);
    sampleList.forEach(price => expect(testList).toContain(price));
}

describe("VendorFilter", () => {
    const filter = vendorFilter();
    const guitars: Guitar[] = [
        { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
        { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
        { Vendor: "Hofner", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
        { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
        { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
        { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
        { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
        { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" },
        { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
        { Vendor: "Rogue", Model: "", Mensura: 0, Price: 3333, ImgPath: "" },
        { Vendor: "Hofner", Model: "", Mensura: 0, Price: 1000, ImgPath: "" },
        { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
        { Vendor: "Kremona", Model: "", Mensura: 0, Price: 7488, ImgPath: "" },
        { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 33101, ImgPath: "" },
        { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6112, ImgPath: "" },
        { Vendor: "Hofner", Model: "", Mensura: 0, Price: 11111, ImgPath: "" }
    ];

    it("returns no records for vendor B.C. Rich", () => {
        const filteredTest = filter(guitars, ['B.C. Rich']);
        const filteredExact = [];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns no records for vendor The Loar", () => {
        const filteredTest = filter(guitars, ['The Loar']);
        const filteredExact = [];
        compareArrays([], filteredTest);
    });

    it("returns no records for vendors B.C. Rich, The Loar", () => {
        const filteredTest = filter(guitars, ['B.C. Rich', 'The Loar']);
        const filteredExact = [];
        compareArrays([], filteredTest);
    });

    it("returns one record for vendor Lucero", () => {
        const filteredTest = filter(guitars, ['Lucero']);
        const filteredExact = [
            { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns one record for vendor Rogue", () => {
        const filteredTest = filter(guitars, ['Rogue']);
        const filteredExact = [
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 3333, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records for vendors Lucero, Rogue", () => {
        const filteredTest = filter(guitars, ['Lucero', 'Rogue']);
        const filteredExact = [
            { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 3333, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns four records for vendor Yamaha", () => {
        const filteredTest = filter(guitars, ['Yamaha']);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 33101, ImgPath: "" },
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns six records for vendors Lucero, Rogue, Yamaha", () => {
        const filteredTest = filter(guitars, ['Lucero', 'Rogue', 'Yamaha']);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 3333, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 33101, ImgPath: "" },
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records for vendor Mitchell", () => {
        const filteredTest = filter(guitars, ['Mitchell']);
        const filteredExact = [
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns four records for vendor Hofner", () => {
        const filteredTest = filter(guitars, ['Hofner']);
        const filteredExact = [
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 1000, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 11111, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records for vendor Kremona", () => {
        const filteredTest = filter(guitars, ['Kremona']);
        const filteredExact = [
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 7488, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns eight records for vendors Mitchell, Hofner, Kremona", () => {
        const filteredTest = filter(guitars, ['Mitchell', 'Hofner', 'Kremona']);
        const filteredExact = [
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 1000, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 7488, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 11111, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns sixteen records for vendors Yamaha, Hofner, Mitchell, Kremona, Lucero, Friedman, Rogue", () => {
        const filteredTest = filter(guitars, ['Yamaha', 'Hofner', 'Mitchell', 'Kremona', 'Lucero', 'Friedman', 'Rogue']);
        compareArrays(guitars, filteredTest);
    });
});