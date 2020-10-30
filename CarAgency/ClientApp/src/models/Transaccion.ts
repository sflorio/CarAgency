export interface Vehiculo {
    VehiculoId: number,    
    Dominio: string,
    Procedencia: string,//lase precedencia
    FechaInscripcionInical: Date,
    Marca: string, // lase marca
    Modelo: string, // lase modelo
    TipoVehiculo: number, //lase TipoVEhiculo
    Ano : number,
    NumeroMotor: string,
    NumeroChasis: string,
    MarcaMotor: string,
    MarcaChasis: string,
    FechaAdquisicion: Date

    TransaccionId number,
	
	ConceptoFinancieroId [int] NULL,
	TipoOperacionId [int] NULL,
	OrigenCuentaId [int] NULL,
	DestinoCuentaId [int] NULL,
    Monto [decimal](18, 2) NOT NULL,
    CreateDateTime [datetime2](7) NOT NULL,
	CreateUser [datetime2](7) NOT NULL,
	UpdateDateTime [datetime2](7) NOT NULL,
	UpdateUser [datetime2](7) NOT NULL,
	DeleteDateTime [datetime2](7) NOT NULL,
	DeleteUser [datetime2](7) NOT NULL,
	Active [bit] NOT NULL,


}