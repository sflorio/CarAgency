import {ITransaccion} from 'models/interfaces/finanzas/ITransaccion';
import ConceptoFinanciero from './ConceptoFinanciero';
import Cuenta from './Cuenta';
import TipoOperacion from './TipoOperacion';

export class Transaccion implements ITransaccion{
    constructor(){
      this.TransaccionId = undefined;
      this.Concepto= undefined;
      this.TipoOperacion= undefined;
      this.Origen= undefined;
      this.Destino= undefined;
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
    Concepto?: ConceptoFinanciero;
    TipoOperacion?: TipoOperacion;
    Origen?: Cuenta;
    Destino?: Cuenta;
    Monto: number;
    CreateDateTime?: Date | undefined;
    CreateUser: string;
    UpdateDateTime?: Date | undefined;
    UpdateUser: string;
    DeleteDateTime?: Date | undefined;
    DeleteUser?: string | undefined;
    Active: Boolean;
    
  }