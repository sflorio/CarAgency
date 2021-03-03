import { ITransaccion } from "domain/interfaces/finanzas/ITransaccion";
import { IMarca } from "domain/interfaces/vehiculos/IMarca";
import { IModelo } from "domain/interfaces/vehiculos/IModelo";

import { ITitular } from "domain/interfaces/personas/ITitular";
import IProcedencia from "domain/interfaces/vehiculos/IProcedencia";
import IRevisionTecnica from "domain/interfaces/vehiculos/revisionestecnicas/IRevisionTecnica";

export interface IVehiculo {
    VehiculoId?: number,    
    Dominio: string,
    Procedencia: IProcedencia,
    FechaInscripcionInical: Date,
    Marca: IMarca,
    Modelo: IModelo,
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