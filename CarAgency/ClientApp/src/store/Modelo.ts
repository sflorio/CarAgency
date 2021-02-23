import { Action, Reducer  } from "redux";
import { AppThunkAction } from "./";
import * as actionTypes from "./actionTypes/modelo"
import axios, { AxiosResponse } from 'axios';

import { IModelo} from "models/interfaces/IModelo";

export interface ModeloState{
    isLoading: boolean;
    startDateIndex?: number;
    page?: number;
    rowsPerPage?: number;
    classes?: object;
    modelo: IModelo[];
}

interface RequestModelosAction{
    type: typeof actionTypes.REQUEST_MODELO;
    startDateIndex: number;
};

interface ReceiveModelosAction{
    type: typeof actionTypes.RECEIVE_MODELO;
    startDateIndex: number;
    modelo: IModelo[];
};


interface GetModelosSucessAction {
    type: typeof actionTypes.GET_MODELO_SUCESS;
    modeloId: number;
};

interface GetModelosFailureAction {
    type: typeof actionTypes.GET_MODELO_FAILURE;
    error: "";
};

interface AddModelosSucessAction {
    type: typeof actionTypes.ADD_MODELO_SUCESS;
    modelo: IModelo;
};

interface AddModelosFailureAction {
    type: typeof actionTypes.ADD_MODELO_FAILURE;
    error: "";
};


interface UpdateModelosSucessAction {
    type: typeof actionTypes.UPDATE_MODELO_SUCESS;
    modelo: IModelo;
};

interface UpdateModelosFailureAction {
    type: typeof actionTypes.UPDATE_MODELO_FAILURE;
    error: "";
};


interface DeleteModelosSucessAction {
    type: typeof actionTypes.DELETE_MODELO_SUCESS;
    modeloId: number;
};

interface DeleteModelosFailureAction {
    type: typeof actionTypes.DELETE_MODELO_FAILURE;
    error: "";
};


type KnownAction = RequestModelosAction | ReceiveModelosAction | GetModelosSucessAction | GetModelosFailureAction | AddModelosSucessAction | AddModelosFailureAction | UpdateModelosSucessAction    | UpdateModelosFailureAction | DeleteModelosSucessAction | DeleteModelosFailureAction;



export const actionCreators = {
    requestModelos: (startDateIndex: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.modelo && startDateIndex !== appState.modelo.startDateIndex) {
            fetch(`modelo`)
                .then(response => response.json() as Promise<IModelo[]>)
                .then(data => {
                    dispatch({ type: actionTypes.RECEIVE_MODELO, startDateIndex: startDateIndex, modelo: data });
                });

            dispatch({ type: actionTypes.REQUEST_MODELO, startDateIndex: startDateIndex });
        }
    },    
    getModelo: (modeloId: number): AppThunkAction<KnownAction> => (dispatch, getState ) =>{

        axios
        .get(`Modelos/` + modeloId)
        .then( Response => Response )
        .then(res => {
          dispatch({ type: actionTypes.GET_MODELO_SUCESS, modeloId });
        }).catch((error)=>{
            console.log(error);
        });

    },
    getAllModelos: async () : Promise<AxiosResponse<any>>  =>  {
        return axios.get('Modelos');

    //     let data: IModelo[] = [];
    //     axios.get('Modelos')
    //     .then(function (response) {
    //         // handle success
    //         data = ( response.data as IModelo[] );
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
    addModelo: (modelo: IModelo): AppThunkAction<KnownAction> => (dispatch, getState) => {

        console.log("addModelo");
        
        axios
      .post(`Modelos`, modelo)
      .then(res => {
        dispatch({ type: actionTypes.ADD_MODELO_SUCESS, modelo: modelo });
      }).catch((error)=>{
        console.log(error);
    });

    },
    updateModelo: (modeloId: number, modelo: IModelo): AppThunkAction<KnownAction> => (dispatch, getState ) =>{
        console.log("updateModelo");
        axios
        .put(`Modelos/` +  modeloId , modelo)
        .then(res => {
          dispatch({ type: actionTypes.UPDATE_MODELO_SUCESS, modelo: modelo });
        }).catch((error)=>{
            console.log(error);
        });

    },
    deleteModelo: (modeloId: number): AppThunkAction<KnownAction> => (dispatch, getState ) =>{
        console.log("deleteModelo");
        axios
        .delete(`Modelos/` + modeloId)
        .then(res => {
          dispatch({ type: actionTypes.DELETE_MODELO_SUCESS, modeloId });
        }).catch((error)=>{
            console.log(error);
        });

    }
};

const unloadedState: ModeloState = { modelo: [], isLoading: false };


export const reducer: Reducer<ModeloState> = (state: ModeloState | undefined, incomingAction: Action): ModeloState => {
    if (state === undefined) {
        return unloadedState;
    }

    const action = incomingAction as KnownAction;
    switch (action.type) {
        case actionTypes.REQUEST_MODELO:
            return {
                startDateIndex: action.startDateIndex,
                modelo: state.modelo,
                isLoading: true
            };
        case actionTypes.RECEIVE_MODELO:
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.startDateIndex === state.startDateIndex) {
                return {
                    startDateIndex: action.startDateIndex,
                    modelo: action.modelo,
                    isLoading: false
                };
            };
        case actionTypes.ADD_MODELO_SUCESS:
            return {
                modelo: state.modelo.concat(action.modelo),
                isLoading: false
            };

        case actionTypes.UPDATE_MODELO_SUCESS:
            return {
                modelo: state.modelo.map(i => ( i.ModeloId === action.modelo.ModeloId ?{...i, descripcion : action.modelo.Descripcion} : i )),
                isLoading: false
            };
        case actionTypes.DELETE_MODELO_SUCESS:
            return {
                modelo: state.modelo.filter(i => i.ModeloId !== action.modeloId),
                isLoading: false
            };
            
        break;
    }

    return state;
};