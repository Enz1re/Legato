export default class Vendor {
    id: number;
    name: string;
    isSelected: boolean;

    constructor (init?: Partial<Vendor>) {
        Object.assign(this, init);
    }
}