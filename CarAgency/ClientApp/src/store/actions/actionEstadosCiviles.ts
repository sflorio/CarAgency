import { Action, Reducer  } from "redux";
import { AppThunkAction } from "..";
import * as actionTypes from "../actionTypes/estadosCiviles";
import axios, { AxiosResponse } from 'axios';

import IEstadoCivil from "models/Interfaces/IEstadoCivil";

export interface EstadosCivilesState{
    isLoading: boolean;
    startDateIndex?: number;
    page?: number;
    rowsPerPage?: number;
    classes?: object;
    EstadosCiviles: IEstadoCivil[];
}

interface RequestEstadosCivilesAction{
    type: typeof actionTypes.REQUEST_ESTADOCIVIL;
    startDateIndex: number;
};

interface ReceiveEstadosCivilesAction{
    type: typeof actionTypes.RECEIVE_ESTADOCIVIL;
    startDateIndex: number;
    EstadosCiviles: IEstadoCivil[];
};


interface GetEstadosCivilesSucessAction {
    type: typeof actionTypes.GET_ESTADOCIVIL_SUCESS;
    EstadosCivilesId: number;
};

interface GetEstadosCivilesFailureAction {
    type: typeof actionTypes.GET_ESTADOCIVIL_FAILURE;
    error: "";
};

interface AddEstadosCivilesSucessAction {
    type: typeof actionTypes.ADD_ESTADOCIVIL_SUCESS;
    EstadosCiviles: IEstadoCivil;
};

interface AddEstadosCivilesFailureAction {
    type: typeof actionTypes.ADD_ESTADOCIVIL_FAILURE;
    error: "";
};


interface UpdateEstadosCivilesSucessAction {
    type: typeof actionTypes.UPDATE_ESTADOCIVIL_SUCESS;
    EstadosCiviles: IEstadoCivil;
};

interface UpdateEstadosCivilesFailureAction {
    type: typeof actionTypes.UPDATE_ESTADOCIVIL_FAILURE;
    error: "";
};


interface DeleteEstadosCivilesSucessAction {
    type: typeof actionTypes.DELETE_ESTADOCIVIL_SUCESS;
    EstadosCivilesId: number;
};

interface DeleteEstadosCivilesFailureAction {
    type: typeof actionTypes.DELETE_ESTADOCIVIL_FAILURE;
    error: "";
};


type KnownAction = RequestEstadosCivilesAction | ReceiveEstadosCivilesAction | GetEstadosCivilesSucessAction | GetEstadosCivilesFailureAction | AddEstadosCivilesSucessAction | AddEstadosCivilesFailureAction | UpdateEstadosCivilesSucessAction    | UpdateEstadosCivilesFailureAction | DeleteEstadosCivilesSucessAction | DeleteEstadosCivilesFailureAction;



export const actionCreators = {
    requestEstadosCiviles: (startDateIndex: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.estadosCiviles && startDateIndex !== appState.estadosCiviles.startDateIndex) {
            fetch(`EstadosCiviles`)
                .then(response => response.json() as Promise<IEstadoCivil[]>)
                .then(data => {
                    dispatch({ type: actionTypes.RECEIVE_ESTADOCIVIL, startDateIndex: startDateIndex, EstadosCiviles: data });
                });

            dispatch({ type: actionTypes.REQUEST_ESTADOCIVIL, startDateIndex: startDateIndex });
        }
    },    
    getEstadosCiviles: (EstadosCivilesId: number): AppThunkAction<KnownAction> => (dispatch, getState ) =>{

        axios
        .get(`EstadosCiviles/` + EstadosCivilesId)
        .then( Response => Response )
        .then(res => {
          dispatch({ type: actionTypes.GET_ESTADOCIVIL_SUCESS, EstadosCivilesId });
        }).catch((error)=>{
            console.log(error);
        });

    },
    getAllEstadosCiviles: async () : Promise<AxiosResponse<any>>  =>  {
        return axios.get('EstadosCiviles');

    //     let data: IEstadoCivil[] = [];
    //     axios.get('EstadosCiviles')
    //     .then(function (response) {
    //         // handle success
    //         data = ( response.data as IEstadoCivil[] );
    //         console.log(data);
    //         return data;
    //     })
    //     .catch(function (error) {
    //         // handle error
    //         console.log(error);
    //     })
    //     .then(function () {
    //         // always executed
    //     });

    //     return data;

    },
    addEstadosCiviles: (EstadosCiviles: IEstadoCivil): AppThunkAction<KnownAction> => (dispatch, getState) => {

        console.log("addEstadosCiviles");
        
        axios
      .post(`EstadosCiviles`, EstadosCiviles)
      .then(res => {
        dispatch({ type: actionTypes.ADD_ESTADOCIVIL_SUCESS, EstadosCiviles: EstadosCiviles });
      }).catch((error)=>{
        console.log(error);
    });

    },
    updateEstadosCiviles: (EstadosCivilesId: number, EstadosCiviles: IEstadoCivil): AppThunkAction<KnownAction> => (dispatch, getState ) =>{
        console.log("updateEstadosCiviles");
        axios
        .put(`EstadosCiviles/` +  EstadosCivilesId , EstadosCiviles)
        .then(res => {
          dispatch({ type: actionTypes.UPDATE_ESTADOCIVIL_SUCESS, EstadosCiviles: EstadosCiviles });
        }).catch((error)=>{
            console.log(error);
        });

    },
    deleteEstadosCiviles: (EstadosCivilesId: number): AppThunkAction<KnownAction> => (dispatch, getState ) =>{
        console.log("deleteEstadosCiviles");
        axios
        .delete(`EstadosCiviles/` + EstadosCivilesId)
        .then(res => {
          dispatch({ type: actionTypes.DELETE_ESTADOCIVIL_SUCESS, EstadosCivilesId });
        }).catch((error)=>{
            console.log(error);
        });

    }
};

const unloadedState: EstadosCivilesState = { EstadosCiviles: [], isLoading: false };


export const reducer: Reducer<EstadosCivilesState> = (state: EstadosCivilesState | undefined, incomingAction: Action): EstadosCivilesState => {
    if (state === undefined) {
        return unloadedState;
    }

    const action = incomingAction as KnownAction;
    switch (action.type) {
        case actionTypes.REQUEST_ESTADOCIVIL:
            return {
                startDateIndex: action.startDateIndex,
                EstadosCiviles: state.EstadosCiviles,
                isLoading: true
            };
        case actionTypes.RECEIVE_ESTADOCIVIL:
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.startDateIndex === state.startDateIndex) {
                return {
                    startDateIndex: action.startDateIndex,
                    EstadosCiviles: action.EstadosCiviles,
                    isLoading: false
                };
            };
        case actionTypes.ADD_ESTADOCIVIL_SUCESS:
            return {
                EstadosCiviles: state.EstadosCiviles.concat(action.EstadosCiviles),
                isLoading: false
            };

        case actionTypes.UPDATE_ESTADOCIVIL_SUCESS:
            return {
                EstadosCiviles: state.EstadosCiviles.map(i => ( i.EstadoCivilId === action.EstadosCiviles.EstadosCivilesId ?{...i, descripcion : action.EstadosCiviles.Descripcion} : i )),
                isLoading: false
            };
        case actionTypes.DELETE_ESTADOCIVIL_SUCESS:
            return {
                EstadosCiviles: state.EstadosCiviles.filter(i => i.EstadoCivilId !== action.EstadosCivilesId),
                isLoading: false
            };
            
        break;
    }

    return state;
};