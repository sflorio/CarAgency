import { IMarca }  from "domain/interfaces/vehiculos/IMarca";
import { Modelo }  from "domain/models/vehiculos/Modelo";

export  class Marca implements IMarca {
    MarcaId? : number | null;
    Descripcion!: string;
    Modelo? : Modelo[];

    public constructor(init?: Partial<Marca>){
        Object.assign(this, init);
    };

}