import RevisionTecnicaConceptoTipo from "models/RevisionTecnicaConceptoTipo";

export default class RevisionTecnicaConcepto {
    
    RevisionTecnicaConceptoId?: number;    
    Descripcion?: string;
    Tipo?: RevisionTecnicaConceptoTipo;

    constructor(){
        this.RevisionTecnicaConceptoId = undefined;
        this.Descripcion = undefined;
        this.Tipo = undefined;
    }

}