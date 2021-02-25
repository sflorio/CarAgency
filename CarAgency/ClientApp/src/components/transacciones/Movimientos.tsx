import React from 'react';
import MaterialTable, { Column } from 'material-table';
import  {Transaccion} from 'domain/models/finanzas/Transaccion';

interface ListaMovimientosProps{
  transacciones?: Transaccion[];
    onChange: (e: any) => void;
    
}

export default class ListaMovimientos extends React.Component<ListaMovimientosProps, { transacciones: Transaccion[]}>{
  dataTipoOperacion = {};
  dataCuenta = {};

  constructor(props : ListaMovimientosProps) {
    super(props);
    this.state = {
      transacciones : JSON.parse(JSON.stringify(( this.props.transacciones != undefined ?this.props.transacciones : [] )))
    }
    this.dataTipoOperacion = { 1: 'Débito', 2: 'Crédito' };
    this.dataCuenta = { 1: 'Cuenta 1', 2: 'Cuenta 2' };
    this.handleOnAddRow = this.handleOnAddRow.bind(this);
  }  

 UpdateParentRepo = (transacciones: Transaccion[]) => {
    this.props.onChange(transacciones);
  }

  handleOnAddRow = (newData: Transaccion) => {
    return new Promise((resolve) => {
      
        setTimeout(() => {
          resolve();
            let data = [...this.state.transacciones, newData];
            this.setState({ transacciones: data } )
            this.UpdateParentRepo(data);
            
        }, 600);
    })

  }

  public render(){
    return (
      <MaterialTable
      title="Lista de Gastos"
      columns={[
        { title: 'TransaccionId', field: 'TransaccionId' },
        { title: 'Concepto', field: 'Concepto' },
        { title: 'TipoOperacion', field: 'TipoOperacion', lookup: this.dataTipoOperacion, },
        { title: 'Origen', field: 'Origen', lookup: this.dataCuenta, },
        { title: 'Destino', field: 'Destino', lookup: this.dataCuenta, },
        { title: 'Monto', field: 'Monto' }
      ]}
      data={this.state.transacciones}  
      editable={{
        onRowAdd: this.handleOnAddRow,
        onRowUpdate: (newData, oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              resolve();
              
              if (oldData != newData) {
                let data = this.state.transacciones.map(i => ( i.TransaccionId === newData.TransaccionId ? newData : i ));
                this.setState({ transacciones: data});
                this.UpdateParentRepo(data);
              }
              

            }, 600);
          }),
        onRowDelete: (oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              resolve();
              let data = this.state.transacciones.filter(i => ( i.TransaccionId != oldData.TransaccionId ));
              this.setState({ transacciones: data});
              this.UpdateParentRepo(data);
                
            }, 600);
          }),
      }}
    />    
    );
  }
}