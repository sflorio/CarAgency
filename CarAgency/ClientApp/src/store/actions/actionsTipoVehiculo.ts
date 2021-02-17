import axios from 'axios';
import { ITipoVehiculo } from "models/interfaces/ITipoVehiculo";
import { TipoVehiculo } from "models/TipoVehiculo";
const serviceBaseModel = "TiposVehiculo";



export const actionCreatorsTipoVehiculo = { 
    getAllTipoVehiculos: () : Promise<TipoVehiculo[]> =>{

        return new Promise((res) =>{
            return [
                { TipoVehiculoId: 1 , Descripcion: "Sedan" },
                { TipoVehiculoId: 2 , Descripcion: "Hatback" },
                { TipoVehiculoId: 3 , Descripcion: "Monovolumen" },
                { TipoVehiculoId: 4 , Descripcion: "Camión" }
            ];
        })
        /*return axios
        .get(serviceBaseModel)
        .then( Response => Response )
        .then(Response => Response.data as unknown as TipoVehiculo[])
        .catch(error => {
            console.log(error);
            return [];
        });*/

    }
};
