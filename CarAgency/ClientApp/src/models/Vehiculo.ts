import {IVehiculo} from "models/interfaces/IVehiculo";
import {Transaccion} from "models/finanzas/Transaccion";
import {Marca} from "models/Marca";
import {Modelo} from "models/Modelo";
import {TipoVehiculo} from "models/TipoVehiculo";
import { Titular } from "./Titular";
import RevisionTecnica from "models/RevisionTecnica";

export class Vehiculo implements IVehiculo{
    constructor(){
      this.VehiculoId = undefined;
      this.Dominio = "";
      this.Procedencia= "";
      this.FechaInscripcionInical= new Date();
      this.Marca = new Marca();
      this.Modelo= new Modelo();
      this.TipoVehiculo= new TipoVehiculo();
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
    Procedencia: string;
    FechaInscripcionInical: Date;
    Marca: Marca;
    Modelo: Modelo;
    TipoVehiculo: TipoVehiculo;
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