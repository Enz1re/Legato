import Vendor from '../src/Vendor';


export default class VendorList {
    vendors: Vendor[];

    constructor(vendors: Vendor[]) {
        this.vendors = vendors;
    }
}