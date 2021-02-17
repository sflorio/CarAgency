import { IMarca }  from "models/interfaces/IMarca";
import { Modelo }  from "models/Modelo";

export  class Marca implements IMarca {
    MarcaId? : number | null;
    Descripcion!: string;
    Modelo? : Modelo[];

    public constructor(init?: Partial<Marca>){
        Object.assign(this, init);
    };

}