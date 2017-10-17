import Guitar from '../../Models/Guitar';


export default function sortByFilter() {
    return (items: Guitar[], fieldName: string) => {
        return items.sort((g1, g2) => {
            if (typeof g1[fieldName] === "string" && typeof g2[fieldName] === "string") {
                return g1[fieldName].length - g2[fieldName].length;
            } else {
                return g1[fieldName] - g2[fieldName];
            }
        })
    }
}