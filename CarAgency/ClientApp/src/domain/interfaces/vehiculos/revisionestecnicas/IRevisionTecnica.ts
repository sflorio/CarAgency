import IRevisionTecnicaConcepto from "domain/interfaces/vehiculos/revisionestecnicas/IRevisionTecnicaConcepto";

export default class IRevisionTecnica {
    RevisionTecnicaId?: number;
    Conceptos?: IRevisionTecnicaConcepto[];
}