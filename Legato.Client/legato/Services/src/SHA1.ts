import { ISHA1 } from "../../Interfaces/interfaces";


interface IShaSum {
    update: (buffer: Uint8Array | string) => void,
    digest: () => string
}


let shared = new Uint32Array(80);

class ShaSum implements IShaSum {
    private h0 = 0x67452301;
    private h1 = 0xEFCDAB89;
    private h2 = 0x98BADCFE;
    private h3 = 0x10325476;
    private h4 = 0xC3D2E1F0;
    private block: Uint32Array;
    private offset = 0;
    private shift = 24;
    private totalLength = 0;

    constructor(sync: boolean) {
        this.block = sync ? shared : new Uint32Array(80);
    }

    update(chunk) {
        if (typeof chunk === "string") {
            return this.updateString(chunk);
        }

        let length = chunk.length;
        this.totalLength += length * 8;
        for (let i = 0; i < length; i++) {
            this.write(chunk[i]);
        }
    }

    digest() {
        this.write(0x80);

        if (this.offset > 14 || (this.offset === 14 && this.shift < 24)) {
            this.processBlock();
        }

        this.offset = 14;
        this.shift = 24;

        // 64-bit length big-endian
        this.write(0x00); // numbers this big aren't accurate in javascript anyway
        this.write(0x00); // ..So just hard-code to zero.
        this.write(this.totalLength > 0xffffffffff ? this.totalLength / 0x10000000000 : 0x00);
        this.write(this.totalLength > 0xffffffff ? this.totalLength / 0x100000000 : 0x00);
        for (let s = 24; s >= 0; s -= 8) {
            this.write(this.totalLength >> s);
        }

        // At this point one last processthis.block() should trigger and we can pull out the result.
        return this.toHex(this.h0) +
            this.toHex(this.h1) +
            this.toHex(this.h2) +
            this.toHex(this.h3) +
            this.toHex(this.h4);
    }

    private updateString(string) {
        var length = string.length;
        this.totalLength += length * 8;
        for (var i = 0; i < length; i++) {
            this.write(string.charCodeAt(i));
        }
    }

    private write(byte) {
        this.block[this.offset] |= (byte & 0xff) << this.shift;
        if (this.shift) {
            this.shift -= 8;
        }
        else {
            this.offset++;
            this.shift = 24;
        }
        if (this.offset === 16) {
            this.processBlock();
        }
    }

    private processBlock() {
        // Extend the sixteen 32-bit words into eighty 32-bit words:
        for (let i = 16; i < 80; i++) {
            let w = this.block[i - 3] ^ this.block[i - 8] ^ this.block[i - 14] ^ this.block[i - 16];
            this.block[i] = (w << 1) | (w >>> 31);
        }

        // log(this.block);
        // Initialize hash value for this chunk:
        let a = this.h0;
        let b = this.h1;
        let c = this.h2;
        let d = this.h3;
        let e = this.h4;
        let f, k;

        // Main loop:
        for (let i = 0; i < 80; i++) {
            if (i < 20) {
                f = d ^ (b & (c ^ d));
                k = 0x5A827999;
            }
            else if (i < 40) {
                f = b ^ c ^ d;
                k = 0x6ED9EBA1;
            }
            else if (i < 60) {
                f = (b & c) | (d & (b | c));
                k = 0x8F1BBCDC;
            }
            else {
                f = b ^ c ^ d;
                k = 0xCA62C1D6;
            }
            let temp = (a << 5 | a >>> 27) + f + e + k + (this.block[i] | 0);
            e = d;
            d = c;
            c = (b << 30 | b >>> 2);
            b = a;
            a = temp;
        }

        // Add this chunk's hash to result so far:
        this.h0 = (this.h0 + a) | 0;
        this.h1 = (this.h1 + b) | 0;
        this.h2 = (this.h2 + c) | 0;
        this.h3 = (this.h3 + d) | 0;
        this.h4 = (this.h4 + e) | 0;

        // The this.block is now reusable.
        this.offset = 0;
        for (let i = 0; i < 16; i++) {
            this.block[i] = 0;
        }
    }

    private toHex(word) {
        var hex = "";
        for (var i = 28; i >= 0; i -= 4) {
            hex += ((word >> i) & 0xf).toString(16);
        }
        return hex;
    }
}


export default class SHA1 implements ISHA1 {
    hash(buffer: Uint8Array | string): string {
        let shasum = this.create(true);
        shasum.update(buffer);
        return shasum.digest();
    }

    private create(sync: boolean): IShaSum {
        return new ShaSum(sync);
    }
}