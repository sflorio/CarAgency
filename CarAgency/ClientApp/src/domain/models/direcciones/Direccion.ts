import IDireccion from "domain/interfaces/direcciones/IDireccion";
import Localidad from "domain/models/direcciones/Localidad";
import Pais from "domain/models/direcciones/Pais";
import Partido from "domain/models/direcciones/Partido";
import Provincia from "domain/models/direcciones/Provincia";

export default class Direccion implements IDireccion {
    constructor(){
    this.DireccionId = 0;
    this.Pais = new Pais();
    this.Provincia = new Provincia();
    this.Partido = new Partido();
    this.Localidad = new Localidad();
    this.Calle = "";
    this.NumeroCalle = "";
    this.CodigoPostal = "";
        
    }
    DireccionId: number;
    Pais: Pais;
    Provincia: Provincia;
    Partido: Partido;
    Localidad: Localidad;
    Calle: string;
    NumeroCalle: string;
    CodigoPostal: string;

}