import  ITipoDocumento from "domain/interfaces/personas/ITipoDocumento";

export default class TipoDocumento  implements ITipoDocumento{
    constructor() {
        this.TipoDocumentoId = 0;
        this.Descripcion = "";
    }

    TipoDocumentoId: number;
    Descripcion: string;
}