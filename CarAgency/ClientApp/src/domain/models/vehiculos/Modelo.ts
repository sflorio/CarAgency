import { IModelo } from "domain/interfaces/vehiculos/IModelo";
import {TipoVehiculo } from "domain/models/vehiculos/TipoVehiculo";

export class Modelo implements IModelo {
    constructor() {
        this.ModeloId = 0;
        this.Descripcion = "";
        this.TipoVehiculo = new TipoVehiculo();
    }
    TipoVehiculo: TipoVehiculo;
    ModeloId?: number;
    Descripcion : string;
}