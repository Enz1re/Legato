import priceFilter from "./PriceFilter";
import { Guitar } from "../../Models/models";
import { Price } from "../../Models/models";


function compareArrays(sample: Guitar[], test: Guitar[]) {
    expect(sample.length).toBe(test.length);
    const sampleList = sample.map(g => g.Price);
    const testList = test.map(g => g.Price);
    sampleList.forEach(price => expect(testList).toContain(price));
}

describe("PriceFilter", () => {
    const filter = priceFilter();
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

    it("returns all records without filtering if no price given", () => {
        const filteredTest = filter(guitars);
        compareArrays(guitars, filteredTest);
    });

    it("returns all records without filtering if an empty price object given", () => {
        const filteredTest = filter(guitars, {});
        compareArrays(guitars, filteredTest);
    });

    it("returns all records without filtering if a price object has more than two properties", () => {
        const filteredTest = filter(guitars, { from: 0, to: 0, fromto: 0 });
        compareArrays(guitars, filteredTest);
    });

    it("returns all records without filtering if price.from is larger than price.to", () => {
        const filteredTest = filter(guitars, { from: 0, to: -1 });
        compareArrays(guitars, filteredTest);
    })

    it("returns one record in range 0-1210", () => {
        const price = { from: 0, to: 1210 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [{ Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" }];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns one record in range *min*-1210", () => {
        const price = { to: 1210 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [{ Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" }];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records in range 0-1211", () => {
        const price = { from: 0, to: 1211 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records in range *min*-1211", () => {
        const price = { to: 1211 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records in range 0-1300", () => {
        const price = { from: 0, to: 1300 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records in range *min*-1300", () => {
        const price = { to: 1300 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records in range 0-1652", () => {
        const price = { from: 0, to: 1652 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records in range *min*-1652", () => {
        const price = { to: 1652 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns three records in range 0-1653", () => {
        const price = { from: 0, to: 1653 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns three records in range *min*-1653", () => {
        const price = { to: 1653 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns five records in range 0-4000", () => {
        const price = { from: 0, to: 4000 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns five records in range *min*-4000", () => {
        const price = { to: 4000 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns six records in range 0-7000", () => {
        const price = { from: 0, to: 7000 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns six records in range *min*-7000", () => {
        const price = { to: 7000 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns six records in range 0-10232", () => {
        const price = { from: 0, to: 10232 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns six records in range *min*-10232", () => {
        const price = { to: 10232 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns seven records in range 0-10233", () => {
        const price = { from: 0, to: 10233 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns seven records in range *min*-10233", () => {
        const price = { to: 10233 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns eight records in range 0-20101", () => {
        const price = { from: 0, to: 20101 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns eight records in range *min*-20101", () => {
        const price = { to: 20101 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns eight records in range 0-*max*", () => {
        const price = { from: 0 };
        const filteredTest = filter(guitars, price);
        compareArrays(guitars, filteredTest);
    });

    it("returns eight records in range 0-30000", () => {
        const price = { from: 0, to: 30000 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns eight records in range *min*-30000", () => {
        const price = { to: 30000 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns two records in range 988-1300", () => {
        const price = { from: 988, to: 1300 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns three records in range 988-1653", () => {
        const price = { from: 988, to: 1653 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns five records in range 988-4000", () => {
        const price = { from: 988, to: 4000 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns four records in range 1211-4000", () => {
        const price = { from: 1211, to: 4000 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        compareArrays(filteredExact, filteredTest);
    });

    it("returns one record in range 3900-10000", () => {
        const price = { from: 3900, to: 10000 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
        ];
        compareArrays(filteredExact, filteredTest);
    });
});