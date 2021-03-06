import React, { useState } from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { ApplicationState } from 'store';
import * as VehiculosStore from 'store/actions/vehiculos';

import { makeStyles, Theme } from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Tabs from '@material-ui/core/Tabs';
import Tab from '@material-ui/core/Tab';

import VehiculoForm from './vehiculoForm';
import TitularForm from 'components/personas/titular/TitularForm';
import Gastos from 'components/transacciones/Movimientos';
import { Container, Button } from '@material-ui/core';

import TabPanel from "components/common/forms/TabPanel";

import {Vehiculo} from "domain/models/vehiculos/Vehiculo";
import {Transaccion} from 'domain/models/finanzas/Transaccion';
import RevisionTecnica from 'domain/models/vehiculos/revisionestecnicas/RevisionTecnica';

import { actionCreators} from "store/actions/vehiculos";

function a11yProps(index: any) {
    return {
      id: `simple-tab-${index}`,
      'aria-controls': `simple-tabpanel-${index}`,
    };
  }
  
type VehiculosProps =  
  & RouteComponentProps<{ VehiculoId: string; }>; // ... plus incoming routing parameters

interface IngresoVehiculoState {
    vehiculo : Vehiculo,
    value: any

}

export default class IngresoVehiculo extends React.Component<VehiculosProps, IngresoVehiculoState> {
  constructor(props: VehiculosProps) {
    super(props);

     this.state = {
        vehiculo: new Vehiculo(),
         value: 0
     };
}

// This method is called when the component is first added to the document
public componentDidMount() {
    this.ensureDataFetched();
  }

  // This method is called when the route parameters change
  public componentDidUpdate() {
    //this.ensureDataFetched();
  }

  private ensureDataFetched() {
    if(this.props.match.params.VehiculoId === undefined )
      return;

    var VehiculoId = Number.parseInt(this.props.match.params.VehiculoId)
    actionCreators.getVehiculo(VehiculoId)
              .then(res => res as Vehiculo)
              .then(_vehiculo => this.setState({vehiculo: _vehiculo}) )
              .catch(e => console.log(e));
  }

   handleChange = (event: React.ChangeEvent<{}>, newValue: number) => {
    this.setState({value: newValue});
  };

  validate = () => {

    return true;
  }

  onSave = ()=> {
    // alert("Dominio es: " + this.state.vehiculo.Dominio + "\n" +
    // "Procedencia es: " + this.state.vehiculo.Procedencia + "\n" +
    // "Ano es: " + this.state.vehiculo.Ano + "\n" +    
    // "NumeroMotor es: " + this.state.vehiculo.NumeroMotor + "\n" 
    // );
    if(this.validate()){
      actionCreators.addVehiculo(this.state.vehiculo);
      console.log(this.state.vehiculo);
    } else {
      console.log("Objeto Vehiculo no paso la validacion " + this.state.vehiculo);
    }
    
  }

  onExit = () => {
    
  }

  public render() {
        return (
            <React.Fragment>
                <Container>
                    <Container>
                        <AppBar position="static">
                            <Tabs value={this.state.value} onChange={this.handleChange} aria-label="simple tabs example">
                              <Tab label="Vehiculo" {...a11yProps(0)} />
                              <Tab label="Ficha Técnica" {...a11yProps(1)} />
                              <Tab label="Gastos" {...a11yProps(2)} />
                            </Tabs>
                        </AppBar>
                        <TabPanel value={this.state.value} index={0}>
                            <VehiculoForm vehiculo={this.state.vehiculo}
                                  onChange={(e: Vehiculo) => {
                                    this.setState({ vehiculo : e});
                                  }} 
                                  ></VehiculoForm>
                            <TitularForm titular={this.state.vehiculo.Titular}
                                  onChange={ (e: any) => { 
                                    this.setState({ vehiculo : {...this.state.vehiculo, Titular : e  }}); 
                                  }}></TitularForm>               
                        </TabPanel>                        
                        <TabPanel value={this.state.value} index={1}>
                            Ficha Tecnica
                        </TabPanel>
                        <TabPanel value={this.state.value} index={2}>
                            <Gastos 
                                  onChange={(e: Transaccion[]) => {
                                    this.setState({ vehiculo : {...this.state.vehiculo, Transacciones : e  }});
                                  }} 
                                  transacciones={this.state.vehiculo.Transacciones}></Gastos>
                        </TabPanel>
                    </Container>
                    <Container>
                        <Button onClick={this.onSave}>Guardar</Button>
                        <Button onClick={this.onExit}>Salir</Button>
                    </Container>                
                </Container>
            </React.Fragment>
        )
    }
}


