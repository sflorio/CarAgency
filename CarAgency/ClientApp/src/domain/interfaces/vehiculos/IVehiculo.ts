import { ITransaccion } from "domain/interfaces/finanzas/ITransaccion";
import { IMarca } from "domain/interfaces/vehiculos/IMarca";
import { IModelo } from "domain/interfaces/vehiculos/IModelo";
import { ITipoVehiculo } from "domain/interfaces/vehiculos/ITipoVehiculo";
import { ITitular } from "domain/interfaces/personas/ITitular";
import IRevisionTecnica from "domain/interfaces/vehiculos/revisionestecnicas/IRevisionTecnica";

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