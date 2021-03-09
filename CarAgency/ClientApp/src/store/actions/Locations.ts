import axios from 'axios';
import Localidad from "domain/models/direcciones/Localidad";
const serviceBaseModel = "Localidades";

export const actionCreator = { 
    getAllLocations: (id: number) : Promise<Localidad[]> =>{
        return axios
        .get(serviceBaseModel + "/" + id )
        .then(Response => Response.data as Localidad[])
        .catch(error => {
            console.log(error);
            return [];
        });
    },
    getAllLocationsByDepartments: (id: number) : Promise<Localidad[]> =>{
        return axios
        .get(serviceBaseModel + "/Partido/" + id )
        .then(Response => Response.data as Localidad[])
        .catch(error => {
            console.log(error);
            return [];
        });
    }
};