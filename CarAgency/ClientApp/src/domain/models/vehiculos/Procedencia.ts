import  IProcedencia from "domain/interfaces/vehiculos/IProcedencia";

export default class Procedencia implements IProcedencia {
    constructor(){
        this.ProcedenciaId = 0;
        this.Descripcion = "";
    }
    
    ProcedenciaId: number;
    Descripcion: string;

}