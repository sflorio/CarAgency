import { IModelo } from "models/interfaces/IModelo";

export class Modelo implements IModelo {
    constructor() {
        this.ModeloId = 0;
        this.Descripcion = "";
    }

    ModeloId?: number;
    Descripcion? : string;
}