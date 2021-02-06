import React, { useState } from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../../store';
import * as VehiculosStore from '../../store/actions/vehiculos';
import MaterialTable, { Column } from 'material-table';

import { makeStyles, Theme } from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Tabs from '@material-ui/core/Tabs';
import Tab from '@material-ui/core/Tab';
import Typography from '@material-ui/core/Typography';
import Box from '@material-ui/core/Box';

import VehiculoForm from './vehiculoForm';
import TitularForm from 'components/titular/TitularForm';
import Gastos from 'components/movimientos/Movimientos';
import { Container, Button } from '@material-ui/core';

import TabPanel from "components/common/forms/TabPanel";

 




function a11yProps(index: any) {
    return {
      id: `simple-tab-${index}`,
      'aria-controls': `simple-tabpanel-${index}`,
    };
  }
  
type VehiculosProps =
  VehiculosStore.VehiculoState // ... state we've requested from the Redux store
  & typeof VehiculosStore.actionCreators // ... plus action creators we've requested
  & RouteComponentProps<{ startDateIndex: string }>; // ... plus incoming routing parameters

//   interface state extends VehiculosProps{
//       value: number
//   }

class IngresoVehiculo extends React.Component<VehiculosProps, any> {
    constructor(props: VehiculosProps) {
        super(props);
        this.state = { 
            value: null        
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

  private ensureDataFetched() {
    const startDateIndex = 0;
    this.props.requestVehiculos(startDateIndex);
  }

   handleChange = (event: React.ChangeEvent<{}>, newValue: number) => {
    this.setState({value: newValue});
  };

  handleOnInputChange = (name: string, value: any) =>{
    this.setState({
        [name]: value 
    });

  };


  onSave = ()=> {
    this.props.addVehiculo(this.state.Vehiculo);
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
                              <Tab label="Titular" {...a11yProps(1)} />
                              <Tab label="Ficha Tecnica" {...a11yProps(2)} />
                              <Tab label="Gastos" {...a11yProps(3)} />
                            </Tabs>
                        </AppBar>
                        <TabPanel value={this.state.value} index={0}>
                            <VehiculoForm onChange={this.handleOnInputChange}></VehiculoForm>
                        </TabPanel>
                        <TabPanel value={this.state.value} index={1}>                            
                            <TitularForm onChange={this.handleOnInputChange}></TitularForm>               
                        </TabPanel>
                        <TabPanel value={this.state.value} index={2}>
                            Ficha Tecnica
                        </TabPanel>
                        <TabPanel value={this.state.value} index={3}>
                            <Gastos ></Gastos>
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



export default connect(
    (state: ApplicationState) => state.vehiculos, // Selects which state properties are merged into the component's props
    VehiculosStore.actionCreators // Selects which action creators are merged into the component's props
  )(IngresoVehiculo as any);
