import IRevisionTecnicaConcepto from "models/interfaces/IRevisionTecnicaConcepto";

export default class IRevisionTecnica {
    RevisionTecnicaId?: number;
    Conceptos?: IRevisionTecnicaConcepto[];
}