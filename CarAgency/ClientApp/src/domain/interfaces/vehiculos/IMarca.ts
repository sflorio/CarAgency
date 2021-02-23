import { IModelo }  from "domain/interfaces/vehiculos/IModelo";

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