import React, { Component, useState } from 'react';
import { Grid } from '@material-ui/core';
import TextFiedl from '@material-ui/core/TextField';
import {ITitular} from "domain/interfaces/personas/ITitular";

export default function TitularForm({titular, onChange  } : { titular: ITitular, onChange: (e:any) => void} ) {

    const [state, setState] = useState(titular);


    const ChangeHandler = (e: any) => {

        new Promise((resolve) => {

            setState({...state, [e.target.name]: e.target.value});

            resolve();
            
        }).then(() => {
            onChange(state);
        });
    }

    return (
        <Grid container>
            <Grid item xs={12} sm={12} md={12} lg={12} >
                Datos del titular:
            </Grid>
            <Grid item xs={12} sm={6} md={6} lg={6} >
                <TextFiedl name="Nombre" label="Nombre" value={state.Nombre} onChange={ChangeHandler}></TextFiedl> 
            </Grid>
            <Grid item xs={12} sm={6}  md={6} lg={6}>
                <TextFiedl name="Apellido" label="Apellido" value={state.Apellido} onChange={ChangeHandler} ></TextFiedl>
            </Grid>                
            <Grid item xs={12} sm={6} lg={6} >
                <TextFiedl name="Dni" label="Dni" value={state.Dni} onChange={ChangeHandler}></TextFiedl>
            </Grid>
            <Grid item xs={12} sm={12} lg={12} >
                <br></br>
            </Grid>
        </Grid>
    )
}
