import React, { Component } from 'react';
import { Grid } from '@material-ui/core';
import TextFiedl from '@material-ui/core/TextField';
import AutocompleteMarcas from 'components/vehiculos/marca/AutocompleteMarcas';
import AutocompleteModelos from 'components/vehiculos/modelo/AutocompleteModelo';
import AutocompleteProcedencias from 'components/vehiculos/vehiculo/procedencia/AutocompleteProcedencia';

import { Vehiculo} from 'domain/models/vehiculos/Vehiculo';
import  {Marca}   from 'domain/models/vehiculos/Marca';
import { Modelo } from 'domain/models/vehiculos/Modelo';
import Procedencia from 'domain/models/vehiculos/Procedencia';

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
        this.props.onChange({...this.props.vehiculo, [e.target.name]: e.target.value});
    };

    onInputChangeMarca = (value?: Marca | null) =>{
        this.inputChange({
            target : {
                name : "Marca",
                value: value
            }
        });
    }

    onInputChangeModelo = (value?: Modelo | null) =>{
        this.inputChange({
            target : {
                name : "Modelo",
                value: value
            }
        });
    }

    onInputChangeProcedencia = (value?: Procedencia | null) =>{
        this.inputChange({
            target : {
                name : "Procedencia",
                value: value
            }
        });
    }

    render() {
        return (
            <Grid container>
                <Grid item xs={12} sm={12} lg={12} >
                    Datos del vehículo:
                </Grid>
                <Grid item xs={12} sm={6} md={6} lg={6} >
                    <TextFiedl name="Dominio" label="Dominio" onChange={this.inputChange} value={this.props.vehiculo.Dominio} ></TextFiedl> 
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="Ano" label="Año" onChange={this.inputChange} value={this.props.vehiculo.Ano}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}  md={6} lg={6}>
                    <AutocompleteProcedencias procedencia={this.props.vehiculo.Procedencia} onChange={this.onInputChangeProcedencia} ></AutocompleteProcedencias>
                </Grid>
                <Grid item xs={12} sm={6}  md={6} lg={6}>
                    <br></br>
                </Grid>
                <Grid item xs={12} sm={6} md={6} lg={6}>
                    <AutocompleteMarcas  marca={this.props.vehiculo.Marca} onChange={this.onInputChangeMarca} ></AutocompleteMarcas>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <AutocompleteModelos modelo={this.props.vehiculo.Modelo} marca={this.props.vehiculo.Marca} onChange={this.onInputChangeModelo} ></AutocompleteModelos>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="NumeroMotor" label="Numero Motor" onChange={this.inputChange} value={this.props.vehiculo.NumeroMotor}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="NumeroChasis" label="Numero Chasis" onChange={this.inputChange} value={this.props.vehiculo.NumeroChasis}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="MarcaMotor" label="Marca Motor" onChange={this.inputChange} value={this.props.vehiculo.MarcaMotor}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="MarcaChasis" label="Marca Chasis" onChange={this.inputChange} value={this.props.vehiculo.MarcaChasis}></TextFiedl>
                </Grid>
                <Grid item xs={12} sm={12} lg={12} >
                    <br></br>
                </Grid>
            </Grid>
        )
    }
}
