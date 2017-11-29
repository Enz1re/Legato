import { IBase64 } from "../../Interfaces/interfaces";


export default class Base64 implements IBase64 {
    encode(inputs: string) {
        return btoa(inputs);
    }

    decode(inputs: string) {
        return atob(inputs);
    }

    encodeUnicode(inputs: string) {
        return btoa(encodeURIComponent(inputs).replace(/%([0-9A-F]{2})/g, (match: string, p1: string) => {
            return String.fromCharCode(parseInt(`0x${p1}`));
        }));
    }

    decodeUnicode(inputs: string) {
        return decodeURIComponent(atob(inputs).split('').map((c) => {
            return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
        }).join(''));
    }
}