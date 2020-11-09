export interface Transaccion {
    TransaccionId: number,	
	ConceptoFinancieroId: number,
	TipoOperacionId: number,
	OrigenCuentaId: number,
	DestinoCuentaId: number,
    Monto: number,
    CreateDateTime: Date,
	CreateUser: Date,
	UpdateDateTime: Date,
	UpdateUser: Date,
	DeleteDateTime: Date,
	DeleteUser: Date,
	Active: Boolean
}