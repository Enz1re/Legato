export interface IBase64 {
    encode(inputs: string): string;
    decode(inputs: string): string;
    encodeUnicode(inputs: string): string;
    decodeUnicode(inputs: string): string;
}