import React,{ useState} from "react";
import { Grid } from '@material-ui/core';
import TextFiedl from '@material-ui/core/TextField';
import IDireccion from "domain/interfaces/direcciones/IDireccion";

import AutocompleteCountry from "./AutocompleteCountry";
import AutocompleteProvince from "./AutocompleteProvince";
import AutocompleteDepartament from "./AutocompleteDepartament";
import AutocompleteLocation from "./AutocompleteLocation";


export default function DireccionForm({direccion, onChange  } : { direccion: IDireccion, onChange: (e:any) => void}) {
    const [state, setState] = useState(direccion);

    const ChangeHandler = (e: any) => {

    }

    return (
        <Grid container>
            <Grid item xs={12} sm={12} md={12} lg={12} >
                Dirección:
            </Grid>
            <Grid item xs={12} sm={6} md={6} lg={6} >
                <AutocompleteCountry pais={state.Pais} onChange={ChangeHandler} ></AutocompleteCountry>
            </Grid>
            <Grid item xs={12} sm={6}  md={6} lg={6}>
                <AutocompleteProvince provincia={state.Provincia} pais={state.Pais} onChange={ChangeHandler}></AutocompleteProvince>
            </Grid>                
            <Grid item xs={12} sm={6} lg={6} >
                <AutocompleteDepartament partido={state.Partido} provincia={state.Provincia} onChange={ChangeHandler}></AutocompleteDepartament>
            </Grid>
            <Grid item xs={12} sm={6} lg={6} >
                <AutocompleteLocation localidad={state.Localidad} partido={state.Partido} onChange={ChangeHandler}></AutocompleteLocation>
            </Grid>
            <Grid item xs={12} sm={6} lg={6} >
                <TextFiedl name="Calle" label="Calle" value={state.Calle} onChange={ChangeHandler}></TextFiedl>
            </Grid>
            <Grid item xs={12} sm={6} lg={6} >
                <TextFiedl name="NumeroCalle" label="Numero Calle" value={state.NumeroCalle} onChange={ChangeHandler}></TextFiedl>
            </Grid>
            <Grid item xs={12} sm={6} lg={6} >
                <TextFiedl name="CodigoPostal" label="Código Postal" value={state.CodigoPostal} onChange={ChangeHandler}></TextFiedl>
            </Grid>
            
            <Grid item xs={12} sm={12} lg={12} >
                <br></br>
            </Grid>
        </Grid>
    )

} 