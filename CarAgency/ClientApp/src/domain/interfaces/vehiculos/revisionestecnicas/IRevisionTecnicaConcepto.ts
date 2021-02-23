import IRevisionTecnicaConceptoTipo from "domain/interfaces/vehiculos/revisionestecnicas/IRevisionTecnicaConceptoTipo";

export default class IRevisionTecnicaConcepto {
    
    RevisionTecnicaConceptoId?: number;    
    Descripcion?: string;
    Tipo?: IRevisionTecnicaConceptoTipo;

}