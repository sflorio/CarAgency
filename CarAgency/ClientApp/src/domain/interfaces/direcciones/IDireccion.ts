import IPais from "domain/interfaces/direcciones/IPais";
import IProvincia from "domain/interfaces/direcciones/IProvincia";
import IPartido from "domain/interfaces/direcciones/IPartido";
import ILocalidad from "domain/interfaces/direcciones/ILocalidad";

export default interface IDireccion {
    DireccionId: number,
    Pais: IPais,
    Provincia: IProvincia,
    Partido: IPartido,
    Localidad: ILocalidad,
    Calle: string,
    NumeroCalle: number,
    CodigoPostal: string
}