import SHA1 from "../src/SHA1";

import { ISHA1 } from "../../Interfaces/interfaces";

const hashes = {
    "user": "12dea96fec20593566ab75692c9949596833adc9",
    "Admin": "4e7afebcfbae000b22c7c85e5560f89a2a0280b4",
    "joxj381059": "52b960cacb18fc5bf23f1dc1442eb47a37f97b58",
    "91B8667448824AE5A6A803E131B13C61": "68113bd0e74a9a1b5f3ca41e63a37b2245b190b2",
    "AAAAAAAA": "c08598945e566e4e53cf3654c922fa98003bf2f9",
    "0": "b6589fc6ab0dc82cf12099d1c2d40ab994e8410c",
    "axatakaaax": "8520b6ae6858b77b48983e35767fcc7e67457f03",
    "^u^": "d23b9d0ff0dbbf832d521622a3773226e2bed108",
    " ": "b858cb282617fb0956d960215c8e84d1ccf909c6",
    "_": "53a0acfad59379b3e050338bf9f23cfc172ee787",
    "": "da39a3ee5e6b4b0d3255bfef95601890afd80709"
};


describe("SHA1", () => {
    let sha1: ISHA1;

    beforeEach(() => {
        sha1 = new SHA1();
    })

    it(`returns ${hashes.user} to 'user'`, () => {
        expect(sha1.hash("user")).toBe(hashes.user);
    });

    it(`returns ${hashes.Admin} to 'Admin'`, () => {
        expect(sha1.hash("Admin")).toBe(hashes.Admin);
    });

    it(`returns ${hashes.joxj381059} to 'joxj381059'`, () => {
        expect(sha1.hash("joxj381059")).toBe(hashes.joxj381059);
    });

    it(`returns ${hashes["91B8667448824AE5A6A803E131B13C61"]} to '91B8667448824AE5A6A803E131B13C61'`, () => {
        expect(sha1.hash("91B8667448824AE5A6A803E131B13C61")).toBe(hashes["91B8667448824AE5A6A803E131B13C61"]);
    });

    it(`returns ${hashes.AAAAAAAA} to 'AAAAAAAA'`, () => {
        expect(sha1.hash("AAAAAAAA")).toBe(hashes.AAAAAAAA);
    });

    it(`returns ${hashes["0"]} to '0'`, () => {
        expect(sha1.hash("0")).toBe(hashes["0"]);
    });

    it(`returns ${hashes.axatakaaax} to 'axatakaaax'`, () => {
        expect(sha1.hash("axatakaaax")).toBe(hashes.axatakaaax);
    });

    it(`returns ${hashes["^u^"]} to '^u^'`, () => {
        expect(sha1.hash("^u^")).toBe(hashes["^u^"]);
    });

    it(`returns ${hashes[" "]} to ' '`, () => {
        expect(sha1.hash(" ")).toBe(hashes[" "]);
    });

    it(`returns ${hashes["_"]} to '_'`, () => {
        expect(sha1.hash("_")).toBe(hashes["_"]);
    });

    it(`returns ${hashes[""]} to ''`, () => {
        expect(sha1.hash("")).toBe(hashes[""]);
    });
});