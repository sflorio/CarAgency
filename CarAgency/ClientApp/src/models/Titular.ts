import { ITitular} from "models/interfaces/ITitular";

export class Titular implements ITitular {
    constructor() {
        this.Nombre = "";
        this.Apellido = "";
        this.Dni = 0;
    }
    
    Nombre: string;
    Apellido: string;
    Dni: number;
    
}