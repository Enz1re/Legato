import Price from "../src/Price";
import VendorList from "../src/VendorList";
import GuitarFilter from "../src/GuitarFilter";


export default class Filter {
    priceFilter: Price;
    vendorFilter: VendorList;
    searchItems: string[];

    constructor(guitarFilter: GuitarFilter) {
        if (guitarFilter.price) {
            this.priceFilter = guitarFilter.price;
        }
        if (guitarFilter.vendors) {
            this.vendorFilter = new VendorList(guitarFilter.vendors.filter(v => v.isSelected));
        }
        if (guitarFilter.search) {
            this.searchItems = guitarFilter.search.toLowerCase().split(" ");
        }
    }
}