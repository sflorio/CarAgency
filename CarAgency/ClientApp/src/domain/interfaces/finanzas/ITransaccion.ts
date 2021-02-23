import ICuenta from "domain/interfaces/finanzas/ICuenta";
import ITipoOperacion from "domain/interfaces/finanzas/ITipoOperacion";

export interface ITransaccion {
    TransaccionId?: number//,	
	ConceptoFinancieroId?: number,
	TipoOperacion?: ITipoOperacion,
	Origen?: ICuenta,
	Destino?: ICuenta,
    Monto: number,
    CreateDateTime?: Date,
	CreateUser: string,
	UpdateDateTime?: Date,
	UpdateUser: string,
	DeleteDateTime?: Date,
	DeleteUser?: string,
	Active: Boolean
}