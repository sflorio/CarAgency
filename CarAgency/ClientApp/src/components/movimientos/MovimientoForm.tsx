import React, { Component } from 'react';
import { Grid } from '@material-ui/core';
import TextFiedl from '@material-ui/core/TextField';
import AutocompleteConceptos from "./conceptos/AutocompleteConceptos";

export default class GastoForm extends Component<any> {
    constructor(props: any) {
        super(props);
    }

    ChangeHandler = (event: any) => {
        this.props.onChange(event);
    }


    public render() {
        return (
            <Grid container>
                <Grid item xs={12} sm={6} md={6} lg={6} >
                    <AutocompleteConceptos></AutocompleteConceptos>
                </Grid>
                <Grid item xs={12} sm={6}  md={6} lg={6}>
                    <TextFiedl name="importe" label="Importe" value={this.props.Importe} onChange={this.ChangeHandler} ></TextFiedl>
                </Grid>
            </Grid>
        )
    }
}
