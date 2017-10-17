export default function booleanFilter() {
    return (input: boolean) => {
        if (input) {
            return "Yes";
        } else {
            return "No";
        }
    }
}