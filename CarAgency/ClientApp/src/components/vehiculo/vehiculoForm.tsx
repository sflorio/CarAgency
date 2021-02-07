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


export default class vehiculoForm extends Component<any> {
    constructor(props: any) {
        super(props);
    }

    ChangeHandler = (event: any) => {
        this.props.onChange(event);
    }

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
