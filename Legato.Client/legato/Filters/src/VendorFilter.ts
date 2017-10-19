import Guitar from '../../Models/Guitar';


export default function vendorFilter() {
    return (items: Guitar[], vendors?: string[]) => {
        if (!vendors) {
            return items;
        }
        if (vendors.length === 0) {
            return [];
        }

        return items.filter(guitar => vendors.indexOf(guitar.Vendor) !== -1);
    }
}