import RevisionTecnicaConceptoTipo from "domain/models/vehiculos/revisionestecnicas/RevisionTecnicaConceptoTipo";

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