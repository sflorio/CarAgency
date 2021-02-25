import ILocalidad from "domain/interfaces/direcciones/ILocalidad";

export default class Localidad implements ILocalidad {
    constructor(){
        this.LocalidadId = 0;
        this.Descripcion = "";
    }

    LocalidadId: number;
    Descripcion: string;

}