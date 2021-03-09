import axios from 'axios';
import Partido from "domain/models/direcciones/Partido";
const serviceBaseModel = "Partidos";

export const actionCreator = { 
    getAllDepartments: (id: number) : Promise<Partido[]> =>{
        return axios
        .get(serviceBaseModel + "/" + id )
        .then(Response => Response.data as Partido[])
        .catch(error => {
            console.log(error);
            return [];
        });
    },
    getAllDepartmentsByProvince: (id: number) : Promise<Partido[]> =>{
        return axios
        .get(serviceBaseModel + "/Provincia/" + id )
        .then(Response => Response.data as Partido[])
        .catch(error => {
            console.log(error);
            return [];
        });
    }
};