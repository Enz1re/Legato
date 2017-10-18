import priceFilter from './PriceFilter';
import Guitar from '../../Models/Guitar';
import Price from '../../Models/Price';


function compareArrays(first: Guitar[], second: Guitar[]) {
    for (let i = 0; i < first.length; i++) {
        expect(first[i].Price).toEqual(second[i].Price);
    }
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
    ]

    it("returns one record in range 0-1210", () => {
        const price = { from: 0, to: 1210 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [{ Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" }];
        expect(filteredTest.length).toBe(1);
        compareArrays(filteredTest, filteredExact);
    });

    it("returns two records in range 0-1211", () => {
        const price = { from: 0, to: 1211 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" }
        ];
        expect(filteredTest.length).toBe(2);
        compareArrays(filteredTest, filteredExact);
    });

    it("returns two records in range 0-1300", () => {
        const price = { from: 0, to: 1300 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" }
        ];
        expect(filteredTest.length).toBe(2);
        compareArrays(filteredTest, filteredExact);
    });

    it("returns two records in range 0-1652", () => {
        const price = { from: 0, to: 1652 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" }
        ];
        expect(filteredTest.length).toBe(2);
        compareArrays(filteredTest, filteredExact);
    });

    it("returns three records in range 0-1653", () => {
        const price = { from: 0, to: 1653 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" }
        ];
        expect(filteredTest.length).toBe(3);
        compareArrays(filteredTest, filteredExact);
    });

    it("returns five records in range 0-4000", () => {
        const price = { from: 0, to: 4000 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        expect(filteredTest.length).toBe(5);
        compareArrays(filteredTest, filteredExact);
    });

    it("returns six records in range 0-7000", () => {
        const price = { from: 0, to: 4000 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        expect(filteredTest.length).toBe(6);
        compareArrays(filteredTest, filteredExact);
    });

    it("returns six records in range 0-10232", () => {
        const price = { from: 0, to: 10232 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        expect(filteredTest.length).toBe(6);
        compareArrays(filteredTest, filteredExact);
    });

    it("returns seven records in range 0-10233", () => {
        const price = { from: 0, to: 10233 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        expect(filteredTest.length).toBe(7);
        compareArrays(filteredTest, filteredExact);
    });

    it("returns eight records in range 0-20101", () => {
        const price = { from: 0, to: 20101 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        expect(filteredTest.length).toBe(8);
        compareArrays(filteredTest, filteredExact);
    });

    it("returns eight records in range 0-30000", () => {
        const price = { from: 0, to: 30000 };
        const filteredTest = filter(guitars, price);
        const filteredExact = [
            { Vendor: "Rogue", Model: "", Mensura: 0, Price: 988, ImgPath: "" },
            { Vendor: "Yamaha", Model: "", Mensura: 0, Price: 1211, ImgPath: "" },
            { Vendor: "B.C. Rich", Model: "", Mensura: 0, Price: 1653, ImgPath: "" },
            { Vendor: "Mitchell", Model: "", Mensura: 0, Price: 3673, ImgPath: "" },
            { Vendor: "Kremona", Model: "", Mensura: 0, Price: 10233, ImgPath: "" },
            { Vendor: "Lucero", Model: "", Mensura: 0, Price: 20101, ImgPath: "" },
            { Vendor: "Friedman", Model: "", Mensura: 0, Price: 6111, ImgPath: "" },
            { Vendor: "Hofner", Model: "", Mensura: 0, Price: 3880, ImgPath: "" }
        ];
        expect(filteredTest.length).toBe(8);
        compareArrays(filteredTest, filteredExact);
    });
});