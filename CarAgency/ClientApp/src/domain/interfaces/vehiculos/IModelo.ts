import ITipoVehiculo from "domain/interfaces/vehiculos/ITipoVehiculo";

export class IModelo {
    ModeloId?: number;
    Descripcion? : string;
    TipoVehiculo?: ITipoVehiculo;
}