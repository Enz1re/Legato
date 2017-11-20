import Vendor from '../src/Vendor';


export default class VendorList {
    vendors: string[];

    constructor(vendors: Vendor[]) {
        this.vendors = vendors.map(v => v.name);
    }
}