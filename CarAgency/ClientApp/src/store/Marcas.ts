import { Action, Reducer  } from "redux";
import { AppThunkAction } from "./";

export interface MarcaState{
    isLoading: boolean;
    startDateIndex?: number;
    marcas: Marca[];
}

export interface Marca{
    marcaId: number,    
    descripcion: string
}

interface RequestMarcasAction{
    type: "REQUEST_MARCA";
    startDateIndex: number;
};

interface ReceiveMarcasAction{
    type: "RECEIVE_MARCA";
    startDateIndex: number;
    marcas: Marca[];
};

type KnownAction = RequestMarcasAction | ReceiveMarcasAction;



export const actionCreators = {
    requestMarcas: (startDateIndex: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.marcas && startDateIndex !== appState.marcas.startDateIndex) {
            fetch(`marcas`)
                .then(response => response.json() as Promise<Marca[]>)
                .then(data => {
                    dispatch({ type: 'RECEIVE_MARCA', startDateIndex: startDateIndex, marcas: data });
                });

            dispatch({ type: 'REQUEST_MARCA', startDateIndex: startDateIndex });
        }
    }
};

const unloadedState: MarcaState = { marcas: [], isLoading: false };


export const reducer: Reducer<MarcaState> = (state: MarcaState | undefined, incomingAction: Action): MarcaState => {
    if (state === undefined) {
        return unloadedState;
    }

    const action = incomingAction as KnownAction;
    switch (action.type) {
        case 'REQUEST_MARCA':
            return {
                startDateIndex: action.startDateIndex,
                marcas: state.marcas,
                isLoading: true
            };
        case 'RECEIVE_MARCA':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.startDateIndex === state.startDateIndex) {
                return {
                    startDateIndex: action.startDateIndex,
                    marcas: action.marcas,
                    isLoading: false
                };
            }
            break;
    }

    return state;
};