import  IEstadoCivil   from "domain/interfaces/personas/IEstadoCivil";

export default class EstadoCivil implements IEstadoCivil {
    EstadoCivilId? : number | null;
    Descripcion!: string;

    public constructor(init?: Partial<EstadoCivil>){
        Object.assign(this, init);
    };

}