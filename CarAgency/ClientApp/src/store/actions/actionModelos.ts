import axios from 'axios';
import { IModelo } from "domain/interfaces/vehiculos/IModelo";
import { Modelo } from "domain/models/vehiculos/Modelo";
const serviceBaseModel = "Modelos";



export const actionCreatorsModelo = {
    requestModelos: (startDateIndex: number) => {
        // Only load data if it's something we don't already have (and are not already loading)
        return fetch(serviceBaseModel)
            .then(response => response.json() as Promise<IModelo[]>)
            .then(data => data as unknown as Modelo[])
            .catch(error => console.log(error));

    },
    getAllModelos: (MarcaId : number) : Promise<Modelo[]> =>{

        return axios
        .get("Marcas/Modelos/" + MarcaId)
        .then(Response => Response.data as unknown as Modelo[])
        .catch(error => {
            console.log(error);
            return [];
        });

    },
    getModelo: (modeloId: number) =>{

        axios
        .get(serviceBaseModel + `/` + modeloId)
        .then( Response => Response )
        .catch((error)=>{
            console.log(error);
        });

    },
    addModelo: (modelo: IModelo) => {

        console.log("addVehiculo");
        
        axios
      .post(serviceBaseModel, modelo)
      .catch((error)=>{
        console.log(error);
    });

    },
    updateModelo: (modeloId: number,modelo:IModelo) => {
        console.log("updateModelo");
        axios
        .put(serviceBaseModel + `/` + modeloId ,modelo)
        .catch((error)=>{
            console.log(error);
        });

    },
    deleteModelo: (modeloId: number) =>{
        console.log("deleteModelo");
        axios
        .delete(serviceBaseModel + `/` + modeloId)
        .catch((error)=>{
            console.log(error);
        });

    }
};
