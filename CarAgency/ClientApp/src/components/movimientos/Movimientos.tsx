
import React, { useState } from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps, Route } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../../store';
import * as VehiculosStore from '../../store/actions/vehiculos';
import MaterialTable, { Column } from 'material-table';


//other custom components
import GastoForm from './GastoForm';

// At runtime, Redux will merge together...
type GastosProps =
  GastosStore.GastoState // ... state we've requested from the Redux store
  & typeof GastosStore.actionCreators // ... plus action creators we've requested
  & RouteComponentProps<{ startDateIndex: string }>; // ... plus incoming routing parameters

class ListaGastos extends React.Component<GastosProps> {
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
        <Route path='ingreso-vehiculo'>
          algo
          </Route>
        <h1 id="tabelLabel">Vehiculos</h1>
        <p>Esta pantalla se utiliza para adminsitrar los vehiculos cargadas en el sistema.</p>
        {this.renderTableMaterial()}
        <Link to="ingreso-vehiculo">Abrir form vehiculo</Link>
      </React.Fragment>
    );
  }

  private ensureDataFetched() {
    const startDateIndex = 0;
    this.props.requestVehiculos(startDateIndex);
  }

 

  private renderTableMaterial(){
    return (
      <MaterialTable
      title="Lista de Gastos"
      columns={[        
        { title: 'Concepto', field: 'Concepto' },
        { title: 'Importe', field: 'Importe' }
      ]}
      data={this.props.vehiculos}  
      editable={{
        onRowAdd: (newData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              this.props.addVehiculo(newData);
              resolve();
            }, 600);
          }),
        onRowUpdate: (newData, oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              if (oldData) {
                this.props.updateVehiculo(( oldData.VehiculoId == null ? 0: oldData.VehiculoId), newData);
                this.props.requestVehiculos(0);
                resolve();
              }
              resolve();
            }, 600);
          }),
        onRowDelete: (oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              
              this.props.deleteVehiculo(( oldData.VehiculoId == null ? 0: oldData.VehiculoId));
              this.props.requestVehiculos(0);
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
  VehiculosStore.actionCreators // Selects which action creators are merged into the component's props
)(ListaVehiculos as any);
