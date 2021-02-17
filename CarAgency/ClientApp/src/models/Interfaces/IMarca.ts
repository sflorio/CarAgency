import { IModelo }  from "models/interfaces/IModelo";

export  class IMarca {
    constructor(){
        this.MarcaId = null,
        this.Descripcion = "null"
        this.Modelo = [];
    }

    MarcaId? : number | null;
    Descripcion : string;
    Modelo? : IModelo[];

}