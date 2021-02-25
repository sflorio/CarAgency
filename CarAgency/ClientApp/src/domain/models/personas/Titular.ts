import Direccion from "domain/models/direcciones/Direccion";
import { ITitular} from "domain/interfaces/personas/ITitular";

export class Titular implements ITitular {
    constructor() {
        this.Nombre = "";
        this.Apellido = "";
        this.Dni = 0;
        this.Direccion = new Direccion();
    }

    Direccion: Direccion;
    Nombre: string;
    Apellido: string;
    Dni: number;
    
}