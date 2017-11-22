export default class Vendor {
    name: string;
    isSelected: boolean;

    constructor (init?: Partial<Vendor>) {
        Object.assign(this, init);
    }
}