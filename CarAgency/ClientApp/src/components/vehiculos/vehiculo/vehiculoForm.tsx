import React, { Component } from 'react';
import { Grid } from '@material-ui/core';
import TextFiedl from '@material-ui/core/TextField';
import AutocompleteMarcas from 'components/vehiculos/marca/AutocompleteMarcas';
import AutocompleteModelos from 'components/vehiculos/modelo/AutocompleteModelo';
import AutocompleteTipoVehiculos from 'components/vehiculos/vehiculo/tipoVehiculo/AutocompleteTipoVehiculo';

import { Vehiculo} from 'domain/models/vehiculos/Vehiculo';
import  {Marca}   from 'domain/models/vehiculos/Marca';
import { Modelo } from 'domain/models/vehiculos/Modelo';
import { TipoVehiculo } from 'domain/models/vehiculos/TipoVehiculo';

interface vehiculoFormProps {
    vehiculo: Vehiculo;
    onChange: (vehiculo: Vehiculo) => void;
}

export default class vehiculoForm extends Component<vehiculoFormProps,Vehiculo> {
    constructor(props: vehiculoFormProps) {
        super(props);
        this.state = this.props.vehiculo;
    }


    inputChange = (e : any) => {
        new Promise((resolve) => {

            this.setState({...this.state, [e.target.name]: e.target.value});

            resolve();
            
        }).then(() => {
            this.props.onChange(this.state);
        });
    };

    onInputChangeMarca = (value?: Marca | null) =>{
        var e = {
            target : {
                name : "Marca",
                value: value
            }
        };
        this.inputChange(e);
    }

    onInputChangeModelo = (value?: Modelo | null) =>{
        var e = {
            target : {
                name : "Modelo",
                value: value
            }
        };
        this.inputChange(e);
    }

    onInputChangeTipoVehiculo = (value?: TipoVehiculo | null) =>{
        var e = {
            target : {
                name : "TipoVehiculo",
                value: value
            }
        };
        this.inputChange(e);
    }


    render() {
        return (
            <Grid container>
                <Grid item xs={12} sm={12} lg={12} >
                    Datos del vehículo:
                </Grid>
                <Grid item xs={12} sm={6} md={6} lg={6} >
                    <TextFiedl name="Dominio" label="Dominio" onChange={this.inputChange} value={this.state.Dominio} ></TextFiedl> 
                </Grid>
                <Grid item xs={12} sm={6}  md={6} lg={6}>
                    <TextFiedl name="Procedencia" label="Procedencia" onChange={this.inputChange} value={this.state.Procedencia} ></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6} md={6} lg={6}>
                    <AutocompleteMarcas  marca={this.state.Marca} onChange={this.onInputChangeMarca} ></AutocompleteMarcas>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <AutocompleteModelos modelo={this.state.Modelo} marca={this.state.Marca} onChange={this.onInputChangeModelo} ></AutocompleteModelos>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <AutocompleteTipoVehiculos tipoVehiculo={this.state.TipoVehiculo} onChange={this.onInputChangeTipoVehiculo}></AutocompleteTipoVehiculos>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="Ano" label="Año" onChange={this.inputChange} value={this.state.Ano}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="NumeroMotor" label="Numero Motor" onChange={this.inputChange} value={this.state.NumeroMotor}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="NumeroChasis" label="Numero Chasis" onChange={this.inputChange} value={this.state.NumeroChasis}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="MarcaMotor" label="Marca Motor" onChange={this.inputChange} value={this.state.MarcaMotor}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="MarcaChasis" label="Marca Chasis" onChange={this.inputChange} value={this.state.MarcaChasis}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={12} lg={12} >
                    <br></br>
                </Grid>
            </Grid>
        )
    }
}
