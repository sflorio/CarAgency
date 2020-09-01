import { Action, Reducer  } from "redux";
import { AppThunkAction } from "../";
import * as actionTypes from "../actionTypes/vehiculos";
import axios from 'axios';


export interface VehiculoState{
    isLoading: boolean;
    startDateIndex?: number;
    vehiculos: Vehiculo[];
}

export interface Vehiculo {
    VehiculoId: number,    
    Dominio: string,
    Procedencia: string,//lase precedencia
    FechaInscripcionInical: Date,
    Marca: string, // lase marca
    Modelo: string, // lase modelo
    TipoVehiculo: number, //lase TipoVEhiculo
    Ano : number,
    NumeroMotor: string,
    NumeroChasis: string,
    MarcaMotor: string,
    MarcaChasis: string,
    FechaAdquisicion: Date
}


interface RequestVehiculosAction{
    type: typeof actionTypes.REQUEST_VEHICULO;
    startDateIndex: number;
};

interface ReceiveVehiculosAction{
    type: typeof actionTypes.RECEIVE_VEHICULO;
    startDateIndex: number;
    vehiculos: Vehiculo[];
};


interface GetVehiculosSucessAction {
    type: typeof actionTypes.GET_VEHICULO_SUCESS;
    vehiculoId: number;
};


interface AddVehiculosSucessAction {
    type: typeof actionTypes.ADD_VEHICULO_SUCESS;
    vehiculo: Vehiculo;
};


interface UpdateVehiculosSucessAction {
    type: typeof actionTypes.UPDATE_VEHICULO_SUCESS;
    vehiculo: Vehiculo;
};

interface DeleteVehiculosSucessAction {
    type: typeof actionTypes.DELETE_VEHICULO_SUCESS;
   vehiculoId: number;
};

type KnownAction = RequestVehiculosAction | ReceiveVehiculosAction | GetVehiculosSucessAction | AddVehiculosSucessAction  | UpdateVehiculosSucessAction    | DeleteVehiculosSucessAction ;



export const actionCreators = {
    requestVehiculos: (startDateIndex: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.vehiculos && startDateIndex !== appState.vehiculos.startDateIndex) {
            fetch(`vehiculos`)
                .then(response => response.json() as Promise<Vehiculo[]>)
                .then(data => {
                    dispatch({ type: actionTypes.RECEIVE_VEHICULO, startDateIndex: startDateIndex, vehiculos: data });
                });

            dispatch({ type: actionTypes.REQUEST_VEHICULO, startDateIndex: startDateIndex });
        }
    },
    getVehiculo: (vehiculoId: number): AppThunkAction<KnownAction> => (dispatch, getState ) =>{

        axios
        .get(`Vehiculos/` + vehiculoId)
        .then( Response => Response )
        .then(res => {
          dispatch({ type: actionTypes.GET_VEHICULO_SUCESS, vehiculoId });
        }).catch((error)=>{
            console.log(error);
        });

    },
    addVehiculo: (vehiculo: Vehiculo): AppThunkAction<KnownAction> => (dispatch, getState) => {

        console.log("addVehiculo");
        
        axios
      .post(`Vehiculos`, vehiculo)
      .then(res => {
        dispatch({ type: actionTypes.ADD_VEHICULO_SUCESS,vehiculo: vehiculo });
      }).catch((error)=>{
        console.log(error);
    });

    },
    updateVehiculo: (vehiculoId: number,Vehiculo:Vehiculo): AppThunkAction<KnownAction> => (dispatch, getState ) =>{
        console.log("updateVehiculo");
        axios
        .put(`Vehiculos/` + vehiculoId ,Vehiculo)
        .then(res => {
          dispatch({ type: actionTypes.UPDATE_VEHICULO_SUCESS, vehiculo: Vehiculo });
        }).catch((error)=>{
            console.log(error);
        });

    },
    deleteVehiculo: (vehiculoId: number): AppThunkAction<KnownAction> => (dispatch, getState ) =>{
        console.log("deleteVehiculo");
        axios
        .delete(`Vehiculos/` +vehiculoId)
        .then(res => {
          dispatch({ type: actionTypes.DELETE_VEHICULO_SUCESS,vehiculoId });
        }).catch((error)=>{
            console.log(error);
        });

    }
};

const unloadedState : VehiculoState = { vehiculos: [], isLoading: false };


export const reducer: Reducer<VehiculoState> = (state: VehiculoState | undefined, incomingAction: Action):VehiculoState => {
    if (state === undefined) {
        return unloadedState;
    }

    const action = incomingAction as KnownAction;
    switch (action.type) {
        case actionTypes.REQUEST_VEHICULO:
            return {
                startDateIndex: action.startDateIndex,
               vehiculos: state.vehiculos,
                isLoading: true
            };
        case actionTypes.RECEIVE_VEHICULO:
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            return ((action.startDateIndex === state.startDateIndex) ? {
                startDateIndex: action.startDateIndex,
                vehiculos: action.vehiculos,
                isLoading: false
            } : unloadedState );
        case actionTypes.ADD_VEHICULO_SUCESS:
            return {
               vehiculos: state.vehiculos.concat(action.vehiculo),
                isLoading: false
            };
        case actionTypes.UPDATE_VEHICULO_SUCESS:
            return {
               vehiculos: state.vehiculos.map(i => ( i.VehiculoId === action.vehiculo.VehiculoId ?{...i, descripcion : action.vehiculo.Dominio} : i )),
                isLoading: false
            };
        case actionTypes.DELETE_VEHICULO_SUCESS:
            return {
               vehiculos: state.vehiculos.filter(i => i.VehiculoId !== action.vehiculoId),
                isLoading: false
            };
            
        break;
    }

    return state;
};

