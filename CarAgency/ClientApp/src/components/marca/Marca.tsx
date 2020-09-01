import React, { useState } from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../../store';
import * as MarcasStore from '../../store/Marcas';
import MaterialTable, { Column } from 'material-table';


//other custom components

// At runtime, Redux will merge together...
type MarcasProps =
  MarcasStore.MarcaState // ... state we've requested from the Redux store
  & typeof MarcasStore.actionCreators // ... plus action creators we've requested
  & RouteComponentProps<{ startDateIndex: string }>; // ... plus incoming routing parameters

class ListaMarcas extends React.Component<MarcasProps> {


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
        <h1 id="tabelLabel">Marcas</h1>
        <p>Esta pantalla se utiliza para adminsitrar las Marcas cargadas en el sistema.</p>
        {this.renderTableMaterial()}
      </React.Fragment>
    );
  }

  private ensureDataFetched() {
    const startDateIndex = 0;
    this.props.requestMarcas(startDateIndex);
  }

  private renderTableMaterial(){
    return (
      <MaterialTable
      title="Lista de Marcas"
      columns={[
        { title: 'Descripción', field: 'descripcion' }
      ]}
      data={this.props.marcas}  
      editable={{
        onRowAdd: (newData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              this.props.addMarca(newData);
              resolve();
            }, 600);
          }),
        onRowUpdate: (newData, oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              if (oldData) {
                this.props.updateMarca(( oldData.marcaId == null ? 0:oldData.marcaId), newData);
                this.props.requestMarcas(0);
                resolve();
              }
              resolve();
            }, 600);
          }),
        onRowDelete: (oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              
              this.props.deleteMarca(( oldData.marcaId == null ? 0:oldData.marcaId));
              this.props.requestMarcas(0);
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
  MarcasStore.actionCreators // Selects which action creators are merged into the component's props
)(ListaMarcas as any);
