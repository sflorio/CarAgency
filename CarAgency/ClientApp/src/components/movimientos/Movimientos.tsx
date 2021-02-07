
import React, { useState } from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps, Route } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../../store';
import * as TransaccionesStore from '../../store/actions/transacciones';
import MaterialTable, { Column } from 'material-table';
import  {ITransaccion} from '../../models/Interfaces/ITransaccion';
import Vehiculo from 'components/vehiculo/Vehiculo';


interface ListaMovimientosProps{
    Transacciones: ITransaccion[];
    onChange: (name: string, value: any) => void;
}

export default class ListaMovimientos extends React.Component<ListaMovimientosProps>{
  constructor(props : ListaMovimientosProps) {
    super(props);

}



UpdateParentRepo = (transacciones: ITransaccion[]) => {
    this.props.onChange("Transacciones",  transacciones);
  }

  public render() {
    return (
      <React.Fragment>
        <Route path='ingreso-movimiento'>
          algo
          </Route>
        <h1 id="tabelLabel">Movimientos</h1>
        <p>En esta pantalla se pueden ver los movimientos</p>
        {this.renderTableMaterial()}        
      </React.Fragment>
    );
  }


  private renderTableMaterial(){
    return (
      <MaterialTable
      title="Lista de Gastos"
      columns={[
        
        { title: 'TransaccionId', field: 'TransaccionId' },
        { title: 'Concepto', field: 'Concepto' },
        { title: 'Monto', field: 'Monto' }
      ]}
      data={this.props.Transacciones}  
      editable={{
        onRowAdd: (newData) =>
          new Promise((resolve) => {
            setTimeout(() => {


              const otransac  = {
                TransaccionId: newData.TransaccionId,	
                ConceptoFinancieroId: 0,
                TipoOperacionId: 0,
                OrigenCuentaId: 0,
                DestinoCuentaId: 0,
                Monto: newData.Monto,
                CreateDateTime: new Date(),
                CreateUser: "",
                UpdateDateTime: new Date(),
                UpdateUser: "",
                DeleteDateTime: new Date(),
                DeleteUser: "",
                Active: true

              };
              
              this.props.Transacciones.concat(otransac);

              this.UpdateParentRepo(this.props.Transacciones);

            }, 600);
          }),
        onRowUpdate: (newData, oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              if (oldData != newData) {
                 
                this.props.Transacciones.map(i => ( i.TransaccionId === newData.TransaccionId ? newData : i ));
                this.UpdateParentRepo(this.props.Transacciones);
              }


            }, 600);
          }),
        onRowDelete: (oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              this.props.Transacciones.map(i => ( i.TransaccionId === oldData.TransaccionId ? null : i ));
              this.UpdateParentRepo(this.props.Transacciones);
            }, 600);
          }),
      }}
    />    
    );
  }
}