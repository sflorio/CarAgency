import React, { useState } from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../../store';
import * as ModeloStore from '../../store/Modelo';
import MaterialTable, { Column } from 'material-table';


//other custom components

// At runtime, Redux will merge together...
type ModeloProps =
  ModeloStore.ModeloState // ... state we've requested from the Redux store
  & typeof ModeloStore.actionCreators // ... plus action creators we've requested
  & RouteComponentProps<{ startDateIndex: string }>; // ... plus incoming routing parameters

class ListaModelo extends React.Component<ModeloProps> {


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
        <h1 id="tabelLabel">Modelo</h1>
        <p>Esta pantalla se utiliza para administrar los Modelos cargados en el sistema.</p>
        {this.renderTableMaterial()}
      </React.Fragment>
    );
  }

  private ensureDataFetched() {
    const startDateIndex = 0;
    this.props.requestModelos(startDateIndex);
  }

  private renderTableMaterial(){
    return (
      <MaterialTable
      title="Lista de Modelos"
      columns={[
        { title: 'Descripción', field: 'Descripcion' }
      ]}
      data={this.props.modelo}  
      editable={{
        onRowAdd: (newData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              this.props.addModelo(newData);
              resolve();
            }, 600);
          }),
        onRowUpdate: (newData, oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              if (oldData) {
                this.props.updateModelo(( oldData.ModeloId == null ? 0:oldData.ModeloId), newData);
                this.props.requestModelo(0);
                resolve();
              }
              resolve();
            }, 600);
          }),
        onRowDelete: (oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              
              this.props.deleteModelo(( oldData.ModeloId == null ? 0:oldData.ModeloId));
              this.props.requestModelo(0);
              resolve();
            }, 600);
          }),
      }}
    />
    );
  }
}

export default connect(
  (state: ApplicationState) => state.modelo, // Selects which state properties are merged into the component's props
  ModeloStore.actionCreators // Selects which action creators are merged into the component's props
)(ListaModelo as any);
