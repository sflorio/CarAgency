import React, { Component } from 'react';
import { Grid } from '@material-ui/core';
import TextFiedl from '@material-ui/core/TextField';

export default class TitularForm extends Component<any> {
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
                    <TextFiedl name="nombre" label="Nombre" value={this.props.Nombre} onChange={this.ChangeHandler}></TextFiedl> 
                </Grid>
                <Grid item xs={12} sm={6}  md={6} lg={6}>
                    <TextFiedl name="apellido" label="Apellido" value={this.props.Apellido} onChange={this.ChangeHandler} ></TextFiedl>
                </Grid>                
                <Grid item xs={12} sm={6}>
                    <TextFiedl name="dni" label="Dni" value={this.props.Dni} onChange={this.ChangeHandler}></TextFiedl>
                </Grid>
            </Grid>
        )
    }
}
