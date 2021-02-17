import { ITransaccion } from "./finanzas/ITransaccion";
import { IMarca } from "./IMarca";
import { IModelo } from "./IModelo";
import { ITipoVehiculo } from "./ITipoVehiculo";
import { ITitular } from "./ITitular";
import IRevisionTecnica from "./IRevisionTecnica";

export interface IVehiculo {
    VehiculoId?: number,    
    Dominio: string,
    Procedencia: string,//lase precedencia
    FechaInscripcionInical: Date,
    Marca: IMarca, // lase marca
    Modelo: IModelo, // lase modelo
    TipoVehiculo: ITipoVehiculo, //lase TipoVEhiculo
    Ano : number,
    NumeroMotor: string,
    NumeroChasis: string,
    MarcaMotor: string,
    MarcaChasis: string,
    FechaAdquisicion: Date,
    RevisionTecnica?: IRevisionTecnica,
    Transacciones?: ITransaccion[],
    Titular: ITitular
}