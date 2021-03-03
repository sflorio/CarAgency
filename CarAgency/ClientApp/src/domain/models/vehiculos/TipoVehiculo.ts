import ITipoVehiculo from "domain/interfaces/vehiculos/ITipoVehiculo";

export class TipoVehiculo implements ITipoVehiculo{
    constructor(){
        this.TipoVehiculoId = 0;
        this.Descripcion = "";        
    }

    TipoVehiculoId: number;
    Descripcion: string;

}