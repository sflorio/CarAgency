
import React, { useState } from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps, Route } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../../store';
import * as TransaccionesStore from '../../store/actions/transacciones';
import MaterialTable, { Column } from 'material-table';
import  * as ITransaccion from '../../models/Transaccion';

//other custom components
import GastoForm from './MovimientoForm';

// At runtime, Redux will merge together...
type MovimientosProps =
  TransaccionesStore.TransaccionState // ... state we've requested from the Redux store
  & typeof TransaccionesStore.actionCreators // ... plus action creators we've requested
  & RouteComponentProps<{ startDateIndex: string }>; // ... plus incoming routing parameters

class Transaccion implements Transaccion{

}

class ListaMovimientos extends React.Component<MovimientosProps> {
  constructor(props: any) {
    super(props);
}




  ChangeHandler = (event: any) => {
      //this.props.onChange(event);
  }


  // This method is called when the component is first added to the document
  public componentDidMount() {
    this.ensureDataFetched();
  }

  // This method is called when the route parameters change
  public componentDidUpdate() {
    this.ensureDataFetched();
  }

  public handleOnAddButtonClick(){


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

  private ensureDataFetched() {
    const startDateIndex = 0;
    this.props.requestTransaccions(startDateIndex);
  }

 

  private renderTableMaterial(){
    return (
      <MaterialTable
      title="Lista de Gastos"
      columns={[        
        { title: 'Concepto', field: 'Concepto' },
        { title: 'Importe', field: 'Importe' }
      ]}
      data={this.props.transacciones}  
      editable={{
        onRowAdd: (newData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              const otransac  = {
                TransaccionId: 0,	
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


              this.props.addTransaccion(otransac);
              resolve();
            }, 600);
          }),
        onRowUpdate: (newData, oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              if (oldData) {
                  this.props.updateTransaccion((oldData.TransaccionId == null ? 0 : oldData.TransaccionId), newData);
                this.props.requestTransaccions(0);
                resolve();
              }
              resolve();
            }, 600);
          }),
        onRowDelete: (oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              
                this.props.deleteTransaccion((oldData.TransaccionId == null ? 0 : oldData.TransaccionId));
              this.props.requestTransaccions(0);
              resolve();
            }, 600);
          }),
      }}
    />    
    );
  }
}

export default connect(
  (state: ApplicationState) => state.vehiculos, // Selects which state properties are merged into the component's props
  TransaccionesStore.actionCreators // Selects which action creators are merged into the component's props
)(ListaMovimientos as any);
