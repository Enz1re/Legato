export default class Price {
    from: number;
    to: number;

    constructor(init?: Partial<Price>) {
        this.from = null;
        this.to = null;
        Object.assign(this, init);
    }
}