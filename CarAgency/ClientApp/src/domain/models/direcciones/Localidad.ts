import ILocalidad from "domain/interfaces/direcciones/ILocalidad";

export default class Localidad implements ILocalidad {
    constructor(){
        this.IdLocalidad = 0;
        this.Descripcion = "";
    }

    IdLocalidad: number;
    Descripcion: string;

}