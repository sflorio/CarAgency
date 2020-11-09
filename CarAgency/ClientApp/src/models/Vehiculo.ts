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
}