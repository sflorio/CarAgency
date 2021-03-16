export default interface IVehiculoListView {
    VehiculoId: number,    
    Dominio: string,
    Procedencia: string,
    FechaInscripcionInical: Date,
    Marca: string,
    Modelo: string,
    Ano : number,
    NumeroMotor: string,
    NumeroChasis: string,
    MarcaMotor: string,
    MarcaChasis: string,
    FechaAdquisicion: Date,
    Titular: string,
    Active: boolean
}