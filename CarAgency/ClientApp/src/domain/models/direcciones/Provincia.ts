import IProvincia from "domain/interfaces/direcciones/IProvincia";

export default class Provincia implements IProvincia {
    constructor(){
        this.ProvinciaId = 0;
        this.Descripcion = "";
    }

    ProvinciaId: number;
    Descripcion: string;

}