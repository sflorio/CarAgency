import { Action, Reducer  } from "redux";
import { AppThunkAction } from "..";
import * as actionTypes from "store/actionTypes/marcas"
import axios, { AxiosResponse } from 'axios';

import { IMarca} from "domain/interfaces/vehiculos/IMarca";

export interface MarcaState{
    isLoading: boolean;
    startDateIndex?: number;
    page?: number;
    rowsPerPage?: number;
    classes?: object;
    marcas: IMarca[];
}

interface RequestMarcasAction{
    type: typeof actionTypes.REQUEST_MARCA;
    startDateIndex: number;
};

interface ReceiveMarcasAction{
    type: typeof actionTypes.RECEIVE_MARCA;
    startDateIndex: number;
    marcas: IMarca[];
};


interface GetMarcasSucessAction {
    type: typeof actionTypes.GET_MARCA_SUCESS;
    marcaId: number;
};

interface GetMarcasFailureAction {
    type: typeof actionTypes.GET_MARCA_FAILURE;
    error: "";
};

interface AddMarcasSucessAction {
    type: typeof actionTypes.ADD_MARCA_SUCESS;
    marcas: IMarca;
};

interface AddMarcasFailureAction {
    type: typeof actionTypes.ADD_MARCA_FAILURE;
    error: "";
};


interface UpdateMarcasSucessAction {
    type: typeof actionTypes.UPDATE_MARCA_SUCESS;
    marcas: IMarca;
};

interface UpdateMarcasFailureAction {
    type: typeof actionTypes.UPDATE_MARCA_FAILURE;
    error: "";
};


interface DeleteMarcasSucessAction {
    type: typeof actionTypes.DELETE_MARCA_SUCESS;
    marcaId: number;
};

interface DeleteMarcasFailureAction {
    type: typeof actionTypes.DELETE_MARCA_FAILURE;
    error: "";
};


type KnownAction = RequestMarcasAction | ReceiveMarcasAction | GetMarcasSucessAction | GetMarcasFailureAction | AddMarcasSucessAction | AddMarcasFailureAction | UpdateMarcasSucessAction    | UpdateMarcasFailureAction | DeleteMarcasSucessAction | DeleteMarcasFailureAction;



export const actionCreators = {
    requestMarcas: (startDateIndex: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.marcas && startDateIndex !== appState.marcas.startDateIndex) {
            fetch(`marcas`)
                .then(response => response.json() as Promise<IMarca[]>)
                .then(data => {
                    dispatch({ type: actionTypes.RECEIVE_MARCA, startDateIndex: startDateIndex, marcas: data });
                });

            dispatch({ type: actionTypes.REQUEST_MARCA, startDateIndex: startDateIndex });
        }
    },    
    getMarca: (marcaId: number): AppThunkAction<KnownAction> => (dispatch, getState ) =>{

        axios
        .get(`Marcas/` + marcaId)
        .then( Response => Response )
        .then(res => {
          dispatch({ type: actionTypes.GET_MARCA_SUCESS, marcaId });
        }).catch((error)=>{
            console.log(error);
        });

    },
    getAllMarcas: async () : Promise<AxiosResponse<any>>  =>  {
        return axios.get('Marcas');

    //     let data: IMarca[] = [];
    //     axios.get('Marcas')
    //     .then(function (response) {
    //         // handle success
    //         data = ( response.data as IMarca[] );
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
    addMarca: (marca: IMarca): AppThunkAction<KnownAction> => (dispatch, getState) => {

        console.log("addMarca");
        
        axios
      .post(`Marcas`, marca)
      .then(res => {
        dispatch({ type: actionTypes.ADD_MARCA_SUCESS, marcas: marca });
      }).catch((error)=>{
        console.log(error);
    });

    },
    updateMarca: (marcaId: number, marca: IMarca): AppThunkAction<KnownAction> => (dispatch, getState ) =>{
        console.log("updateMarca");
        axios
        .put(`Marcas/` +  marcaId , marca)
        .then(res => {
          dispatch({ type: actionTypes.UPDATE_MARCA_SUCESS, marcas: marca });
        }).catch((error)=>{
            console.log(error);
        });

    },
    deleteMarca: (marcaId: number): AppThunkAction<KnownAction> => (dispatch, getState ) =>{
        console.log("deleteMarca");
        axios
        .delete(`Marcas/` + marcaId)
        .then(res => {
          dispatch({ type: actionTypes.DELETE_MARCA_SUCESS, marcaId });
        }).catch((error)=>{
            console.log(error);
        });

    }
};

const unloadedState: MarcaState = { marcas: [], isLoading: false };


export const reducer: Reducer<MarcaState> = (state: MarcaState | undefined, incomingAction: Action): MarcaState => {
    if (state === undefined) {
        return unloadedState;
    }

    const action = incomingAction as KnownAction;
    switch (action.type) {
        case actionTypes.REQUEST_MARCA:
            return {
                startDateIndex: action.startDateIndex,
                marcas: state.marcas,
                isLoading: true
            };
        case actionTypes.RECEIVE_MARCA:
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.startDateIndex === state.startDateIndex) {
                return {
                    startDateIndex: action.startDateIndex,
                    marcas: action.marcas,
                    isLoading: false
                };
            };
        case actionTypes.ADD_MARCA_SUCESS:
            return {
                marcas: state.marcas.concat(action.marcas),
                isLoading: false
            };

        case actionTypes.UPDATE_MARCA_SUCESS:
            return {
                marcas: state.marcas.map(i => ( i.MarcaId === action.marcas.MarcaId ?{...i, descripcion : action.marcas.Descripcion} : i )),
                isLoading: false
            };
        case actionTypes.DELETE_MARCA_SUCESS:
            return {
                marcas: state.marcas.filter(i => i.MarcaId !== action.marcaId),
                isLoading: false
            };
            
        break;
    }

    return state;
};