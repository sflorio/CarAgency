import React, { useState } from 'react';
import { RouteComponentProps } from 'react-router';
import * as ModeloStore from 'store/actions/actionModelos';
import MaterialTable, { Column } from 'material-table';
import {Modelo} from "domain/models/vehiculos/Modelo";
import {actionCreatorsModelo} from 'store/actions/actionModelos';

//other custom components

// At runtime, Redux will merge together...


class ListaModelo extends React.Component<{props: any},{modelos: Modelo[]}> {
  constructor(props: any){
    super(props);
    this.state = {
      modelos: [ new Modelo]
    };
  } 

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
    actionCreatorsModelo.requestModelos(startDateIndex);
  }

  private renderTableMaterial(){
    return (
      <MaterialTable
      title="Lista de Modelos"
      columns={[
        { title: 'Descripción', field: 'Descripcion' }
      ]}
      data={this.state.modelos}  
      editable={{
        onRowAdd: (newData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              actionCreatorsModelo.addModelo(newData);
              this.setState({ modelos : [...this.state.modelos, newData] } )
              resolve();
            }, 600);
          }),
        onRowUpdate: (newData, oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              if (oldData) {
                actionCreatorsModelo.updateModelo(( oldData.ModeloId == null ? 0: oldData.ModeloId), newData);
                var modelosUpdated = this.state.modelos;
                modelosUpdated = modelosUpdated.map((e) => ( e.ModeloId == oldData.ModeloId ? newData : oldData ));
                this.setState({ modelos : modelosUpdated});

                resolve();
              }
              resolve();
            }, 600);
          }),
        onRowDelete: (oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              
              actionCreatorsModelo.deleteModelo(( oldData.ModeloId == null ? 0:oldData.ModeloId));

              var modelosUpdated = this.state.modelos;
                modelosUpdated = modelosUpdated.filter((e) => ( e.ModeloId != oldData.ModeloId ));
                this.setState({ modelos : modelosUpdated});
              
              resolve();
            }, 600);
          }),
      }}
    />
    );
  }
}

export default ListaModelo;
