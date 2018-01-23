import { GuitarModalController } from "./GuitarModalController";

import {
    Price,
    Guitar,
    Vendor,
    Sorting
} from "../../../Models/models";

import { IRoutingService, IUrlParamResolver } from "../../../Interfaces/interfaces";

const guitars: Guitar[] = [
    { id: 0, vendor: { id: 0, name: "Vendor", isSelected: true }, model: "Model", mensura: 500, price: 13000, imgPath: "" },
    { id: 1, vendor: { id: 1, name: "Vendor", isSelected: true }, model: "Model", mensura: 500, price: 13000, imgPath: "" },
    { id: 2, vendor: { id: 2, name: "Vendor", isSelected: true }, model: "Model", mensura: 500, price: 13000, imgPath: "" },
    { id: 3, vendor: { id: 3, name: "Vendor", isSelected: true }, model: "Model", mensura: 500, price: 13000, imgPath: "" },
    { id: 4, vendor: { id: 4, name: "Vendor", isSelected: true }, model: "Model", mensura: 500, price: 13000, imgPath: "" },
    { id: 5, vendor: { id: 5, name: "Vendor", isSelected: true }, model: "Model", mensura: 500, price: 13000, imgPath: "" },
    { id: 6, vendor: { id: 6, name: "Vendor", isSelected: true }, model: "Model", mensura: 500, price: 13000, imgPath: "" },
    { id: 7, vendor: { id: 7, name: "Vendor", isSelected: true }, model: "Model", mensura: 500, price: 13000, imgPath: "" },
    { id: 8, vendor: { id: 8, name: "Vendor", isSelected: true }, model: "Model", mensura: 500, price: 13000, imgPath: "" },
    { id: 9, vendor: { id: 9, name: "Vendor", isSelected: true }, model: "Model", mensura: 500, price: 13000, imgPath: "" },
    { id: 10, vendor: { id: 10, name: "Vendor", isSelected: true }, model: "Model", mensura: 500, price: 13000, imgPath: "" },
    { id: 11, vendor: { id: 11, name: "Vendor", isSelected: true }, model: "Model", mensura: 500, price: 13000, imgPath: "" }
];


describe("GuitarModalController", () => {
    let routingService: IRoutingService;
    let guitarModal0: GuitarModalController;
    let guitarModal11: GuitarModalController;
    let guitarModal5: GuitarModalController;
    let guitarModal20: GuitarModalController;
    let guitarModalminus1: GuitarModalController;

    beforeEach(() => {
        routingService = <IRoutingService>{
            url: "http://localhost:8080",
            urlSegments: ["", "classical"],
            queryParams: {},
            getParamResolver: jasmine.createSpy("getParamResolver").and.returnValue(<IUrlParamResolver>{
                resolvePage: (maxPage?: number) => {
                    return 1;
                },
                resolvePrice: () => {
                    return new Price();
                },
                resolveVendors: (vendorList: Vendor[]) => {
                    return [];
                },
                resolveSorting: () => {
                    return new Sorting();
                },
                resolveSearchString: () => {
                    return "";
                },
                resolveIndex: (maxIndex?: number) => {
                    return 1;
                }
            }),
            redirect: jasmine.createSpy("redirect"),
            replace: jasmine.createSpy("replace")
        };

        guitarModal0 = new GuitarModalController(routingService, guitars, 0);
        guitarModal11 = new GuitarModalController(routingService, guitars, 11);
        guitarModal5 = new GuitarModalController(routingService, guitars, 5);
        guitarModal20 = new GuitarModalController(routingService, guitars, 20);
        guitarModalminus1 = new GuitarModalController(routingService, guitars, -1);
    });

    it("initializes controller with guitar list and initial index with 0", () => {
        expect(guitarModal0.guitars).toEqual(guitars);
        expect(guitarModal0.currentIndex).toBe(0);
    });

    it("changes current index to 1", () => {
        guitarModal0.next();
        expect(guitarModal0.currentIndex).toBe(1);
    });

    it("doesn't change current index if it is 0", () => {
        guitarModal0.prev();
        expect(guitarModal0.currentIndex).toBe(0);
    });

    it("initializes controller with guitar list and initial index with 11", () => {
        expect(guitarModal11.guitars).toEqual(guitars);
        expect(guitarModal11.currentIndex).toBe(11);
    });

    it("doesn't change current index if it is already last index", () => {
        guitarModal11.next();
        expect(guitarModal11.currentIndex).toBe(11);
    });

    it("changes current index to 10", () => {
        guitarModal11.prev();
        expect(guitarModal11.currentIndex).toBe(10);
    });

    it("initializes controller with guitar list and initial index with 5", () => {
        expect(guitarModal5.guitars).toEqual(guitars);
        expect(guitarModal5.currentIndex).toBe(5);
    });

    it("changes current index to 6", () => {
        guitarModal5.next();
        expect(guitarModal5.currentIndex).toBe(6);
    });

    it("changes current index to 4", () => {
        guitarModal5.prev();
        expect(guitarModal5.currentIndex).toBe(4)
    });

    it("initializes controller with guitar list and initial index with 11", () => {
        expect(guitarModal20.guitars).toEqual(guitars);
        expect(guitarModal20.currentIndex).toBe(11);
    });

    it("doesn't change current index if it is already last index", () => {
        guitarModal20.next();
        expect(guitarModal20.currentIndex).toBe(11);
    });

    it("changes current index to 10", () => {
        guitarModal20.prev();
        expect(guitarModal20.currentIndex).toBe(10)
    });

    it("initializes controller with guitar list and initial index with 0", () => {
        expect(guitarModalminus1.guitars).toEqual(guitars);
        expect(guitarModalminus1.currentIndex).toBe(0);
    });

    it("changes current index to 1", () => {
        guitarModalminus1.next();
        expect(guitarModalminus1.currentIndex).toBe(1);
    });

    it("doesn't change current index if it is 0", () => {
        guitarModalminus1.prev();
        expect(guitarModalminus1.currentIndex).toBe(0)
    });
});