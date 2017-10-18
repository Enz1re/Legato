import Guitar from '../../Models/Guitar';


export default function vendorFilter() {
    return (items: Guitar[], vendors: string[]) => {
        if (!vendors) {
            return items;
        }

        return items.filter(guitar => vendors.indexOf(guitar.Vendor) !== -1);
    }
}