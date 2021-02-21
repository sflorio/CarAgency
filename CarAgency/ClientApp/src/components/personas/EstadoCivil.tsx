import React, { useState } from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../../store';
import * as EstadosCivilesStore from '../../store/actions/actionEstadosCiviles';
import MaterialTable, { Column } from 'material-table';


//other custom components

// At runtime, Redux will merge together...
type EstadosCivilesProps =
  EstadosCivilesStore.EstadosCivilesState // ... state we've requested from the Redux store
  & typeof EstadosCivilesStore.actionCreators // ... plus action creators we've requested
  & RouteComponentProps<{ startDateIndex: string }>; // ... plus incoming routing parameters

class ListaEstadosCiviles extends React.Component<EstadosCivilesProps> {


  // This method is called when the component is first added to the document
  public componentDidMount() {
    this.ensureDataFetched();
  }

  // This method is called when the route parameters change
  public componentDidUpdate() {
    this.ensureDataFetched();
  }


  public render() {
    return (
      <React.Fragment>
        <h1 id="tabelLabel">EstadosCiviles</h1>
        <p>Esta pantalla se utiliza para adminsitrar las EstadosCiviles cargadas en el sistema.</p>
        {this.renderTableMaterial()}
      </React.Fragment>
    );
  }

  private ensureDataFetched() {
    const startDateIndex = 0;
    this.props.requestEstadosCiviles(startDateIndex);
  }

  private renderTableMaterial(){
    return (
      <MaterialTable
      title="Lista de EstadosCiviles"
      columns={[
        { title: 'Descripción', field: 'Descripcion' }
      ]}
      data={this.props.EstadosCiviles}  
      editable={{
        onRowAdd: (newData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              this.props.addEstadosCiviles(newData);
              resolve();
            }, 600);
          }),
        onRowUpdate: (newData, oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              if (oldData) {
                this.props.updateEstadosCiviles(( oldData.EstadoCivilId == null ? 0:oldData.EstadoCivilId), newData);
                this.props.requestEstadosCiviles(0);
                resolve();
              }
              resolve();
            }, 600);
          }),
        onRowDelete: (oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              
              this.props.deleteEstadosCiviles(( oldData.EstadoCivilId == null ? 0:oldData.EstadoCivilId));
              this.props.requestEstadosCiviles(0);
              resolve();
            }, 600);
          }),
      }}
    />
    );
  }
}

export default connect(
  (state: ApplicationState) => state.marcas, // Selects which state properties are merged into the component's props
  EstadosCivilesStore.actionCreators // Selects which action creators are merged into the component's props
)(ListaEstadosCiviles as any);
