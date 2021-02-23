import IPais from "domain/interfaces/direcciones/IPais";

export default class Pais implements IPais {
    constructor(){
        this.IdPais = 0;
        this.Descripcion = "";
    }

    IdPais: number;
    Descripcion: string;

}