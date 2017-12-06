import Vendor from "../src/Vendor";


export default class Guitar {
    private _id: number;
    vendor: Vendor;
    model: string;
    mensura: number;
    price: number;
    imgPath: string;

    get id() {
        return this._id;
    }
}