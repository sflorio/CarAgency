import React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps, Route } from 'react-router';
import { Link, Redirect, withRouter } from 'react-router-dom';
import { ApplicationState } from 'store';
import * as VehiculosStore from 'store/actions/vehiculos';
import MaterialTable, { Column } from 'material-table';
import {actionCreators} from "store/actions/vehiculos"
import IVehiculoListView from "domain/interfaces/vehiculos/IVehiculoListView";

export default class ListaVehiculos extends React.Component<any, { vehiculos: IVehiculoListView[]}> {
  constructor(props: any){
    super(props);
    this.state = {
      vehiculos: []
    }
  }

  // This method is called when the component is first added to the document
  public componentDidMount() {
    this.ensureDataFetched();
  }

  // This method is called when the route parameters change
  public componentDidUpdate() {
    //this.ensureDataFetched();
  }

  pathToAddEditVehiculo = "/vehiculo/ingreso-vehiculo";
  TEXT_LABEL = "Vehiculos";
  FORM_DESCRIPTION = "Esta pantalla se utiliza para administrar los vehiculos cargados.";
  
  public handleOnAddButtonClick(){


  }


  nextPath(path: any) {
    this.props.history.push(path);
  }


  public render() {
    return (
      <React.Fragment>
       
        <h1 id="tabelLabel">{this.TEXT_LABEL}</h1>
        <p>{this.FORM_DESCRIPTION}</p>
        {this.renderTableMaterial()}        
      </React.Fragment>
    );
  }

  private ensureDataFetched() {

    actionCreators.listView(1,20).then(response => this.setState({ vehiculos : response}) );
  }

  private renderTableMaterial(){
    return (
      <MaterialTable
      options={{
        exportButton: true
      }}
      title="Lista de Vehiculos"
      columns={[
        { title: 'Id', field: 'VehiculoId', hidden:true, export:true },        
        { title: 'Dominio', field: 'Dominio' },
        { title: 'Procedencia', field: 'Procedencia' },
        { title: 'Inscripción Inical', field: 'FechaInscripcionInical', type: 'datetime' },
        { title: 'Marca', field: 'Marca' },
        { title: 'Modelo', field: 'Modelo' },
        { title: 'Tipo Vehiculo', field: 'TipoVehiculo' },
        { title: 'Titular', field: 'Titular' },
        { title: 'Año', field: 'Ano' }
      ]}
      data={this.state.vehiculos}
      actions={[
        {
          icon: 'add',
          tooltip: 'Add User',
          isFreeAction: true,
          onClick: (event) => this.nextPath(this.pathToAddEditVehiculo) 
        },
        {
          icon: 'save',
          tooltip: 'Save User',
          onClick: (event, rowData) =>this.nextPath(this.pathToAddEditVehiculo + "/" + rowData.VehiculoId  )  
        } 
      ]}
      editable={{
           
        onRowDelete: (oldData) =>
          new Promise((resolve) => {
            setTimeout(() => {
              
              actionCreators.deleteVehiculo(oldData.VehiculoId).then(res => {
                var list = this.state.vehiculos;
                list = list.filter(e => e.VehiculoId != res.VehiculoId );
                this.setState({ vehiculos : list} );
              } ).catch(e => {
                console.log(e);
              });
              

              resolve();
            }, 600);
          }),
      }}
    />
    );
  }
}
