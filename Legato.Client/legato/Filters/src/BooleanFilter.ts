export default function booleanFilter() {
    return (input: boolean) => {
        if (typeof input !== "boolean") {
            return input;
        }

        return input ? "Yes" : "No";
    }
}