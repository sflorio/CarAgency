import IDireccion from "domain/interfaces/direcciones/IDireccion";

export interface ITitular {
    Nombre: string,
    Apellido: string,
    Dni: number,
    Direccion: IDireccion
}