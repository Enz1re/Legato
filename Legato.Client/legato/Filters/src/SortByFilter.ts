import Guitar from '../../Models/Guitar';


export default function sortByFilter() {
    return (items: Guitar[], fieldName: string, direction: string) => {
        if (!fieldName) {
            return items;
        }

        return items.sort((g1, g2) => {
            if (typeof g1[fieldName] === "string" && typeof g2[fieldName] === "string") {
                return g1[fieldName] < g2[fieldName] ? -1 : g1[fieldName] > g2[fieldName] ? 1 : 0;
            } else {
                if (direction === "Ascending") {
                    return g1[fieldName] - g2[fieldName];
                } else if (direction === "Descending") {
                    return g2[fieldName] - g1[fieldName];
                } else {
                    return 0;
                }
            }
        });
    }
}