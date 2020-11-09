import React, { Component } from 'react';
import { Grid } from '@material-ui/core';
import TextFiedl from '@material-ui/core/TextField';
/*
import {DatePicker} from '@material-ui/pickers';
import MomentUtils from '@date-io/moment';
*/
import AutocompleteMarcas from 'components/marca/AutocompleteMarcas';
import AutocompleteModelos from 'components/modelo/AutocompleteModelo';
import AutocompleteTipoVehiculos from 'components/vehiculo/tipoVehiculo/AutocompleteTipoVehiculo';
import {Vehiculo} from 'models/Transaccion';


interface state extends Vehiculo {
}

export default class vehiculoForm extends Component<any> {
    constructor(props: any) {
        super(props);
        // this.state = {
        //     VehiculoId: props.VehiculoId,
        //     Dominio: props.Dominio,
        //     Procedencia: props.Procedencia,
        //     FechaInscripcionInical : props.FechaInscripcionInical,
        //     Marca: props.Marca,
        //     Modelo: props.Modelo,
        //     TipoVehiculo : props.TipoVehiculo,
        //     Ano: props.Ano,
        //     NumeroMotor: props.NumeroMotor,
        //     NumeroChasis: props.NumeroChasis,
        //     MarcaMotor: props.MarcaMotor,
        //     MarcaChasis: props.MarcaChasis,
        //     FechaAdquisicion: props.FechaAdquisicion
        // };
    }

    ChangeHandler = (event: any) => {
        this.props.onChange(event);
    }

    // procedenciaChangeHandler = (event: any) => {
    //     this.setState({Procedencia: event.target.value});
    // }

    // fechaInscripcionInicalChangeHandler = (event: any) => {
    //     this.setState({FechaInscripcionInical: event.target.value});
    // }

    // marcaChangeHandler = (event: any) => {
    //     this.setState({Marca: event.target.value});
    // }

    // modeloChangeHandler = (event: any) => {
    //     this.setState({Modelo: event.target.value});
    // }

    // tipoVehiculoChangeHandler = (event: any) => {
    //     this.setState({TipoVehiculo: event.target.value});
    // }

    // anoChangeHandler = (event: any) => {
    //     this.setState({Ano: event.target.value});
    // }
    
    // numeroMotorChangeHandler = (event: any) => {
    //     this.setState({NumeroMotor: event.target.value});
    // }

    // numeroChasisChangeHandler = (event: any) => {
    //     this.setState({NumeroChasis: event.target.value});
    // }

    // marcaMotorChangeHandler = (event: any) => {
    //     this.setState({MarcaMotor: event.target.value});
    // }

    // marcaChasisChangeHandler = (event: any) => {
    //     this.setState({MarcaChasis: event.target.value});
    // }

    // fechaAdquisicionChangeHandler = (event: any) => {
    //     this.setState({FechaAdquisicion: event.target.value});
    // }

    render() {
        return (
            <Grid container>
                <Grid item xs={12} sm={6} md={6} lg={6} >
                    <TextFiedl name="dominio" label="Dominio" value={this.props.Dominio} onChange={this.ChangeHandler}></TextFiedl> 
                </Grid>
                <Grid item xs={12} sm={6}  md={6} lg={6}>
                    <TextFiedl name="procedencia" label="Procedencia" value={this.props.Procedencia} onChange={this.ChangeHandler} ></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6} md={6} lg={6}> 
                  
                </Grid>
                <Grid item xs={12} sm={6} md={6} lg={6}>
                    <AutocompleteMarcas ></AutocompleteMarcas>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <AutocompleteModelos></AutocompleteModelos>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <AutocompleteTipoVehiculos></AutocompleteTipoVehiculos>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="ano" label="Año" value={this.props.Ano} onChange={this.ChangeHandler}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="numeroMotor" label="Numero Motor" value={this.props.NumeroMotor} onChange={this.ChangeHandler}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="numeroChasis" label="Numero Chasis" value={this.props.NumeroChasis} onChange={this.ChangeHandler}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="marcaMotor" label="Marca Motor" value={this.props.MarcaMotor} onChange={this.ChangeHandler}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="marcaChasis" label="Marca Chasis" value={this.props.MarcaChasis} onChange={this.ChangeHandler} ></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}>
                </Grid>
            </Grid>
        )
    }
}
