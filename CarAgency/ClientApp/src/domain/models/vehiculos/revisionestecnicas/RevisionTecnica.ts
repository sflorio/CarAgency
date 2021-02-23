import RevisionTecnicaConcepto from "domain/models/vehiculos/revisionestecnicas/RevisionTecnicaConcepto";

export default class RevisionTecnica {
    RevisionTecnicaId?: number;
    Conceptos?: RevisionTecnicaConcepto[];

    public constructor(){
        this.RevisionTecnicaId = undefined;
        this.Conceptos = undefined;
    }



}