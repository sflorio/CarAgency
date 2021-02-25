import IConceptoFinanciero from "domain/interfaces/finanzas/IConceptoFinanciero";

export default class ConceptoFinanciero implements IConceptoFinanciero{
    ConceptoFinancieroId?: number;
    Descripcion?: string;
}