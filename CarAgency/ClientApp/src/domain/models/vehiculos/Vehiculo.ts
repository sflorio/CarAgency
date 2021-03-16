import {IVehiculo} from "domain/interfaces/vehiculos/IVehiculo";
import {Transaccion} from "domain/models/finanzas/Transaccion";
import {Marca} from "domain/models/vehiculos/Marca";
import {Modelo} from "domain/models/vehiculos/Modelo";
import {TipoVehiculo} from "domain/models/vehiculos/TipoVehiculo";
import { Titular } from "domain/models/personas/Titular";
import Procedencia from "domain/models/vehiculos/Procedencia";

import RevisionTecnica from "domain/models/vehiculos/revisionestecnicas/RevisionTecnica";

export class Vehiculo implements IVehiculo{
    constructor(){
      this.VehiculoId = undefined;
      this.Dominio = "";
      this.Procedencia= new Procedencia();
      this.FechaInscripcionInical= new Date();
      this.Marca = new Marca();
      this.Modelo= new Modelo();
      this.Ano= 2020;
      this.NumeroMotor = "";
      this.NumeroChasis= "";
      this.MarcaMotor= "";
      this.MarcaChasis= "";
      this.FechaAdquisicion= new Date();
      this.RevisionTecnica = undefined;
      this.Transacciones = undefined; 
      this.Titular = new Titular();
    };
  
    VehiculoId?: number;
    Dominio: string;
    Procedencia: Procedencia;
    FechaInscripcionInical: Date;
    Marca: Marca;
    Modelo: Modelo;
    Ano: number;
    NumeroMotor: string;
    NumeroChasis: string;
    MarcaMotor: string;
    MarcaChasis: string;
    FechaAdquisicion: Date;
    RevisionTecnica?: RevisionTecnica;
    Transacciones?: Transaccion[];
    Titular: Titular;
  }