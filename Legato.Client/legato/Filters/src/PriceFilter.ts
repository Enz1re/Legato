import { Guitar } from "../../Models/models";


export default function priceFilter() {
    return (items: Guitar[], price?: any) => {
        // check if price object is valid
        if (!price || Object.keys(price).length === 0 || Object.keys(price).length > 2) {
            return items;
        }
        if (price.from > price.to) {
            return items;
        }

        let from = price.from;
        let to = price.to;

        if (!from) {
            from = 0;
        }
        if (!to) {
            // get the largest price if it is not set for defaults
            to = items.sort((g1, g2) => g2.Price - g1.Price)[0].Price;
        }

        return items.filter(guitar => from <= guitar.Price && guitar.Price <= to);
    }
}