import {ITransaccion} from 'models/Interfaces/ITransaccion';

export class Transaccion implements ITransaccion{
    constructor(){
      this.TransaccionId = 0;
      this.ConceptoFinancieroId= 0;
      this.TipoOperacionId= 0;
      this.OrigenCuentaId =0;
      this.DestinoCuentaId = 0;
      this.Monto = 0;
      this.CreateDateTime = new Date();
      this.CreateUser = "";
      this.UpdateDateTime = undefined;
      this.UpdateUser = "";
      this.DeleteDateTime = undefined;
      this.DeleteUser = "";
      this.Active= true;
    };
  
    TransaccionId?: number | undefined;
    ConceptoFinancieroId?: number | undefined;
    TipoOperacionId?: number | undefined;
    OrigenCuentaId?: number | undefined;
    DestinoCuentaId?: number | undefined;
    Monto: number;
    CreateDateTime?: Date | undefined;
    CreateUser: string;
    UpdateDateTime?: Date | undefined;
    UpdateUser: string;
    DeleteDateTime?: Date | undefined;
    DeleteUser?: string | undefined;
    Active: Boolean;
    
  }