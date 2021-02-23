import IProvincia from "domain/interfaces/direcciones/IProvincia";

export default class Provincia implements IProvincia {
    constructor(){
        this.IdProvincia = 0;
        this.Descripcion = "";
    }

    IdProvincia: number;
    Descripcion: string;

}