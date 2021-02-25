import IPais from "domain/interfaces/direcciones/IPais";

export default class Pais implements IPais {
    constructor(){
        this.PaisId = 0;
        this.Descripcion = "";
    }

    PaisId: number;
    Descripcion: string;

}