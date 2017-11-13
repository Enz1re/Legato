export default class Price {
    from: number;
    to: number;

    constructor(init?: Partial<Price>) {
        Object.assign(this, init);
    }
}