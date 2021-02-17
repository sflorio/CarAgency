import { Action, Reducer  } from "redux";
import { AppThunkAction } from "../";
import * as actionTypes from "../actionTypes/vehiculos";
import axios from 'axios';
import { IModelo } from "models/interfaces/IModelo";
import { Modelo } from "models/Modelo";
const serviceBaseModel = "Modelos";



export const actionCreators = {
    requestModelos: (startDateIndex: number) => {
        // Only load data if it's something we don't already have (and are not already loading)
        return fetch(serviceBaseModel)
            .then(response => response.json() as Promise<IModelo[]>)
            .then(data => data as unknown as Modelo[])
            .catch(error => console.log(error));

    },
    getModelo: (modeloId: number) =>{

        axios
        .get(serviceBaseModel + `/` + modeloId)
        .then( Response => Response )
        .then(res => {
          
            //dispatch({ type: actionTypes.GET_VEHICULO_SUCESS, modeloId });

        }).catch((error)=>{
            console.log(error);
        });

    },
    addVehiculo: (modelo: IModelo) => {

        console.log("addVehiculo");
        
        axios
      .post(serviceBaseModel, modelo)
      .then(res => {
        //dispatch({ type: actionTypes.ADD_VEHICULO_SUCESS,vehiculo: modelo });
      }).catch((error)=>{
        console.log(error);
    });

    },
    updateVehiculo: (modeloId: number,modelo:IModelo) => {
        console.log("updateModelo");
        axios
        .put(serviceBaseModel + `/` + modeloId ,modelo)
        .then(res => {
          
            //dispatch({ type: actionTypes.UPDATE_VEHICULO_SUCESS, vehiculo: modelo });


        }).catch((error)=>{
            console.log(error);
        });

    },
    deleteVehiculo: (modeloId: number) =>{
        console.log("deleteModelo");
        axios
        .delete(serviceBaseModel + `/` +modeloId)
        .then(res => {

          //dispatch({ type: actionTypes.DELETE_VEHICULO_SUCESS,modeloId });
        }).catch((error)=>{
            console.log(error);
        });

    }
};
