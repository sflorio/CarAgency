import React, { useState } from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps, Route } from 'react-router';
import { Link, Redirect } from 'react-router-dom';
import { ApplicationState } from 'store';
import * as VehiculosStore from 'store/actions/vehiculos';
import MaterialTable, { Column } from 'material-table';


//other custom components
import IngresoVehiculo from './IngresoVehiculo';


// At runtime, Redux will merge together...
type VehiculosProps =
  VehiculosStore.VehiculoState // ... state we've requested from the Redux store
  & typeof VehiculosStore.actionCreators // ... plus action creators we've requested
  & RouteComponentProps<{ startDateIndex: string }>
  & { redirect: null }; // ... plus incoming routing parameters

class ListaVehiculos extends React.Component<VehiculosProps> {
  // This method is called when the component is first added to the document
  public componentDidMount() {
    this.ensureDataFetched();
  }

  // This method is called when the route parameters change
  public componentDidUpdate() {
    this.ensureDataFetched();
    }
  pathToAddEditVehiculo = "/vehiculo/ingreso-vehiculo";

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
      options={{
        exportButton: true
      }}
      title="Lista de Vehiculos"
      columns={[        
        { title: 'Dominio', field: 'Dominio' },
        { title: 'Procedencia', field: 'Procedencia' },
        { title: 'Inscripción Inical', field: 'FechaInscripcionInical' },
        { title: 'Marca', field: 'Marca' },
        { title: 'Modelo', field: 'Modelo' },
        { title: 'Tipo Vehiculo', field: 'TipoVehiculo' },
        { title: 'Año', field: 'Ano' }
      ]}
      data={this.props.vehiculos}
      
      // actions={[
      //   {
      //     icon: 'save',
      //     tooltip: 'Save User',
      //     onClick: (event, rowData) => <Link to="ingreso-vehiculo">Abrir form vehiculo</Link>

      //   }
      // ]}

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
