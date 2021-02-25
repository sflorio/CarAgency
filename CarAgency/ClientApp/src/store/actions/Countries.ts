import axios from 'axios';
import Pais from "domain/models/direcciones/Pais";
const serviceBaseModel = "Paises";

export const actionCreator = { 
    getAllCountries: () : Promise<Pais[]> =>{
        return axios
        .get(serviceBaseModel)
        .then(Response => Response.data as Pais[])
        .catch(error => {
            console.log(error);
            return [];
        });
    }
};