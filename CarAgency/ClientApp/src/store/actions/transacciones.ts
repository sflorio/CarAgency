import { Action, Reducer  } from "redux";
import { AppThunkAction } from "..";
import * as actionTypes from "store/actionTypes/transacciones";
import axios from 'axios';
import { ITransaccion } from "domain/interfaces/finanzas/ITransaccion"

export interface TransaccionState{
    isLoading: boolean;
    startDateIndex?: number;
    VehiculoId?: number;
    transacciones: ITransaccion[];
}

interface RequestTransaccionsAction{
    type: typeof actionTypes.REQUEST_TRANSACCION;
    startDateIndex: number;
};

interface RequestTransaccionsByVehiculoAction{
    type: typeof actionTypes.REQUEST_TRANSACCION_BY_VEHICULO;
    VehiculoId?: number;
};

interface ReceiveTransaccionsAction{
    type: typeof actionTypes.RECEIVE_TRANSACCION;
    startDateIndex: number;
    transacciones: ITransaccion[];
};


interface ReceiveTransaccionsByVehiculoAction{
    type: typeof actionTypes.RECEIVE_TRANSACCION_BY_VEHICULO;
    VehiculoId?: number;
    transacciones: ITransaccion[];
};


interface GetTransaccionsSucessAction {
    type: typeof actionTypes.GET_TRANSACCION_SUCESS;
    transaccionId: number;
};

interface AddTransaccionsSucessAction {
    type: typeof actionTypes.ADD_TRANSACCION_SUCESS;
    transaccion: ITransaccion;
};

interface UpdateTransaccionsSucessAction {
    type: typeof actionTypes.UPDATE_TRANSACCION_SUCESS;
    transaccion: ITransaccion;
};

interface DeleteTransaccionsSucessAction {
    type: typeof actionTypes.DELETE_TRANSACCION_SUCESS;
   transaccionId: number;
};

type KnownAction = RequestTransaccionsAction | RequestTransaccionsByVehiculoAction | ReceiveTransaccionsAction | ReceiveTransaccionsByVehiculoAction | GetTransaccionsSucessAction | AddTransaccionsSucessAction  | UpdateTransaccionsSucessAction    | DeleteTransaccionsSucessAction ;

export const actionCreators = {
    requestTransaccions: (startDateIndex: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.transacciones && startDateIndex !== appState.transacciones.startDateIndex) {
            fetch(`transacciones`)
                .then(response => response.json() as Promise<ITransaccion[]>)
                .then(data => {
                    dispatch({ type: actionTypes.RECEIVE_TRANSACCION, startDateIndex: startDateIndex, transacciones: data });
                });

            dispatch({ type: actionTypes.REQUEST_TRANSACCION, startDateIndex: startDateIndex });
        }
    },
    requestTransaccionsByVehiculo: (VehiculoId?: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.transacciones) {
            fetch(`transacciones/ByVehiculo/` + VehiculoId)
                .then(response => response.json() as Promise<ITransaccion[]>)
                .then(data => {
                    dispatch({ type: actionTypes.RECEIVE_TRANSACCION_BY_VEHICULO, VehiculoId: VehiculoId, transacciones: data });
                });

            dispatch({ type: actionTypes.REQUEST_TRANSACCION_BY_VEHICULO, VehiculoId: VehiculoId });
        }
    },
    getTransaccion: (transaccionId: number): AppThunkAction<KnownAction> => (dispatch, getState ) =>{

        axios
        .get(`Transacciones/` + transaccionId)
        .then( Response => Response )
        .then(res => {
          dispatch({ type: actionTypes.GET_TRANSACCION_SUCESS, transaccionId });
        }).catch((error)=>{
            console.log(error);
        });

    },
    addTransaccion: (transaccion: ITransaccion): AppThunkAction<KnownAction> => (dispatch, getState) => {

        console.log("addTransaccion");

        axios
      .post(`Transacciones`, transaccion)
      .then(res => {
        dispatch({ type: actionTypes.ADD_TRANSACCION_SUCESS,transaccion: transaccion });
      }).catch((error)=>{
        console.log(error);
    });

    },
    updateTransaccion: (transaccionId: number,Transaccion:ITransaccion): AppThunkAction<KnownAction> => (dispatch, getState ) =>{
        console.log("updateTransaccion");
        axios
        .put(`Transacciones/` + transaccionId ,Transaccion)
        .then(res => {
          dispatch({ type: actionTypes.UPDATE_TRANSACCION_SUCESS, transaccion: Transaccion });
        }).catch((error)=>{
            console.log(error);
        });

    },
    deleteTransaccion: (transaccionId: number): AppThunkAction<KnownAction> => (dispatch, getState ) =>{
        console.log("deleteTransaccion");
        axios
        .delete(`Transacciones/` +transaccionId)
        .then(res => {
          dispatch({ type: actionTypes.DELETE_TRANSACCION_SUCESS,transaccionId });
        }).catch((error)=>{
            console.log(error);
        });
    }
};

const unloadedState : TransaccionState = { transacciones: [], isLoading: false };

export const reducer: Reducer<TransaccionState> = (state: TransaccionState | undefined, incomingAction: Action):TransaccionState => {
    if (state === undefined) {
        return unloadedState;
    }

    const action = incomingAction as KnownAction;
    switch (action.type) {
        case actionTypes.REQUEST_TRANSACCION:
            return {
                startDateIndex: action.startDateIndex,
               transacciones: state.transacciones,
                isLoading: true
            };
        case actionTypes.RECEIVE_TRANSACCION:
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            return ((action.startDateIndex === state.startDateIndex) ? {
                startDateIndex: action.startDateIndex,
                transacciones: action.transacciones,
                isLoading: false
            } : unloadedState );
        case actionTypes.ADD_TRANSACCION_SUCESS:
            return {
               transacciones: state.transacciones.concat(action.transaccion),
                isLoading: false
            };
        case actionTypes.UPDATE_TRANSACCION_SUCESS:
            return {
               transacciones: state.transacciones.map(i => ( i.TransaccionId === action.transaccion.TransaccionId ?{...i, TransaccionId : action.transaccion.TransaccionId} : i )),
                isLoading: false
            };
        case actionTypes.DELETE_TRANSACCION_SUCESS:
            return {
                transacciones: state.transacciones.filter(i => i.TransaccionId !== action.transaccionId),
                isLoading: false
            };
            
        break;
    }

    return state;
};

