import IRevisionTecnicaConceptoTipo from "models/interfaces/IRevisionTecnicaConceptoTipo";

export default class IRevisionTecnicaConcepto {
    
    RevisionTecnicaConceptoId?: number;    
    Descripcion?: string;
    Tipo?: IRevisionTecnicaConceptoTipo;

}