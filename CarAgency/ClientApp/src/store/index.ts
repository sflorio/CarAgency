import * as Marcas from './Marcas';
import * as Vehiculos from 'store/actions/vehiculos';
import * as Transacciones from 'store/actions/transacciones';

// The top-level state object
export interface ApplicationState {
    marcas: Marcas.MarcaState | undefined;
    vehiculos: Vehiculos.VehiculoState | undefined;
    transacciones: Transacciones.TransaccionState | undefined;
}

// Whenever an action is dispatched, Redux will update each top-level application state property using
// the reducer with the matching name. It's important that the names match exactly, and that the reducer
// acts on the corresponding ApplicationState property type.
export const reducers = {
    marcas : Marcas.reducer,
    vehiculos : Vehiculos.reducer,
    transacciones : Transacciones.reducer
};

// This type can be used as a hint on action creators so that its 'dispatch' and 'getState' params are
// correctly typed to match your store.
export interface AppThunkAction<TAction> {
    (dispatch: (action: TAction) => void, getState: () => ApplicationState): void;
}
