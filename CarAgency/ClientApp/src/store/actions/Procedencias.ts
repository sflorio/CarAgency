import axios from 'axios';
import  IProcedencia  from "domain/interfaces/vehiculos/IProcedencia";
import  Procedencia from "domain/models/vehiculos/Procedencia";
const serviceBaseModel = "Procedencia";



export const actionCreators = {
    requestProcedencias: (startDateIndex: number) => {
        // Only load data if it's something we don't already have (and are not already loading)
        return fetch(serviceBaseModel)
            .then(response => response.json() as Promise<IProcedencia[]>)
            .then(data => data as unknown as Procedencia[])
            .catch(error => console.log(error));

    },
    getAllProcedencias: () : Promise<Procedencia[]> =>{

        return axios
        .get(serviceBaseModel)
        .then(Response => Response.data as unknown as Procedencia[])
        .catch(error => {
            console.log(error);
            return [];
        });

    },
    getProcedencia: (procedenciaId: number) =>{

        axios
        .get(serviceBaseModel + `/` + procedenciaId)
        .then( Response => Response )
        .catch((error)=>{
            console.log(error);
        });

    },
    addProcedencia: (Procedencia: IProcedencia) => {

        console.log("addVehiculo");
        
        axios
      .post(serviceBaseModel, Procedencia)
      .catch((error)=>{
        console.log(error);
    });

    },
    updateProcedencia: (procedenciaId: number,Procedencia:IProcedencia) => {
        console.log("updateProcedencia");
        axios
        .put(serviceBaseModel + `/` + procedenciaId ,Procedencia)
        .catch((error)=>{
            console.log(error);
        });

    },
    deleteProcedencia: (procedenciaId: number) =>{
        console.log("deleteProcedencia");
        axios
        .delete(serviceBaseModel + `/` + procedenciaId)
        .catch((error)=>{
            console.log(error);
        });

    }
};
