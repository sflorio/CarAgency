import axios from 'axios';
import Provincia from "domain/models/direcciones/Provincia";
const serviceBaseModel = "Provincias";

export const actionCreator = { 
    getAllProvinces: (id: number) : Promise<Provincia[]> =>{
        return axios
        .get(serviceBaseModel + "/" + id)
        .then(Response => Response.data as Provincia[])
        .catch(error => {
            console.log(error);
            return [];
        });
    },
    getAllProvincesByCountry: (id: number) : Promise<Provincia[]> =>{
        return axios
        .get(serviceBaseModel + "/Pais/" + id)
        .then(Response => Response.data as Provincia[])
        .catch(error => {
            console.log(error);
            return [];
        });
    }
};
