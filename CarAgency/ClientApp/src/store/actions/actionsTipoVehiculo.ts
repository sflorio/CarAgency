import axios from 'axios';
import { ITipoVehiculo } from "models/interfaces/ITipoVehiculo";
import { TipoVehiculo } from "models/TipoVehiculo";
const serviceBaseModel = "TiposVehiculo";



export const actionCreatorsTipoVehiculo = { 
    getAllTipoVehiculos: () : Promise<TipoVehiculo[]> =>{

        return axios
        .get(serviceBaseModel)
        .then( Response => Response )
        .then(Response => Response.data as unknown as TipoVehiculo[])
        .catch(error => {
            console.log(error);
            return [];
        });

    }
};
