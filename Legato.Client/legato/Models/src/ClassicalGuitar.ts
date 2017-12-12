import Guitar from "./Guitar";


export default class ClassicalGuitar extends Guitar {
    stringType: "Nylon" | "Fluorocarbon";

    stringTypes(): ("Nylon" | "Fluorocarbon")[] {
        return ["Nylon", "Fluorocarbon"];
    }
}