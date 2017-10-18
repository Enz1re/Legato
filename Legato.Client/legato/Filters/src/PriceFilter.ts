import Guitar from '../../Models/Guitar';
import Price from '../../Models/Price';


export default function priceFilter() {
    return (items: Guitar[], price: Price) => {
        // check if price object is defined and it has at least one property set
        if (!price || Object.keys(price).length === 0) {
            return items;
        }

        let from = price.from;
        let to = price.to;

        if (!from) {
            from = 0;
        }
        if (!to) {
            // get the largest price if it is not set for defaults
            to = items.sort((g1, g2) => g1.Price - g2.Price)[items.length - 1].Price;
        }

        return items.filter(guitar => from <= guitar.Price && guitar.Price <= to);
    }
}