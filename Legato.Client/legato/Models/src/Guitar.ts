import Vendor from "../src/Vendor";


export default class Guitar {
    readonly id: number;
    vendor: Vendor;
    model: string;
    mensura: number;
    price: number;
    imgPath: string;
}