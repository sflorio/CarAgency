import IPartido from "domain/interfaces/direcciones/IPartido";

export default class Partido implements IPartido {
    constructor(){
        this.PartidoId = 0;
        this.Descripcion = "";
    }

    PartidoId: number;
    Descripcion: string;

}