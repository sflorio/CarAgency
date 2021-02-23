import IPartido from "domain/interfaces/direcciones/IPartido";

export default class Partido implements IPartido {
    constructor(){
        this.IdPartido = 0;
        this.Descripcion = "";
    }

    IdPartido: number;
    Descripcion: string;

}