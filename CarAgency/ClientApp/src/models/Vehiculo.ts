import {IVehiculo} from "models/Interfaces/IVehiculo";
import {Transaccion} from "models/Transaccion";

export class Vehiculo implements IVehiculo{
    constructor(){
      this.VehiculoId = 0;
      this.Dominio = "";
      this.Procedencia= "";
      this.FechaInscripcionInical= new Date();
      this.Marca = "";
      this.Modelo= "";
      this.TipoVehiculo= 0;
      this.Ano= 2020;
      this.NumeroMotor = "";
      this.NumeroChasis= "";
      this.MarcaMotor= "";
      this.MarcaChasis= "";
      this.FechaAdquisicion= new Date();
      this.Transacciones = [new Transaccion()]; 
    };
  
    VehiculoId: number;
    Dominio: string;
    Procedencia: string;
    FechaInscripcionInical: Date;
    Marca: string;
    Modelo: string;
    TipoVehiculo: number;
    Ano: number;
    NumeroMotor: string;
    NumeroChasis: string;
    MarcaMotor: string;
    MarcaChasis: string;
    FechaAdquisicion: Date;
    Transacciones: Transaccion[];
  
  
  }