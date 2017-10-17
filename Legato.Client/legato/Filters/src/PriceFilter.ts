import Guitar from '../../Models/Guitar';
import Price from '../../Models/Price';


export default function vendorFilter() {
    return (items: Guitar[], price: Price) => {
        return items.filter(guitar => price.from <= guitar.Price && guitar.Price <= price.to);
    }
}