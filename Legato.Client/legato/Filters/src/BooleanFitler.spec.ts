import booleanFilter from './BooleanFilter';


describe("BooleanFilter", () => {
    const filter = booleanFilter();

    it("returns 'Yes' when given true boolean value", () => {
        const value = filter(true);
        expect(value).toBe("Yes");
    });

    it("returns 'No' when given false boolean value", () => {
        const value = filter(false);
        expect(value).toBe("No");
    });
});