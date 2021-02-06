export interface Transaccion {
    TransaccionId?: number,	
	ConceptoFinancieroId?: number,
	TipoOperacionId?: number,
	OrigenCuentaId?: number,
	DestinoCuentaId?: number,
    Monto: number,
    CreateDateTime?: Date,
	CreateUser: string,
	UpdateDateTime?: Date,
	UpdateUser: string,
	DeleteDateTime?: Date,
	DeleteUser?: string,
	Active: Boolean
}