import React,{ useState} from "react";
import { Grid } from '@material-ui/core';
import TextFiedl from '@material-ui/core/TextField';
import IDireccion from "domain/interfaces/direcciones/IDireccion";

import AutocompleteCountry from "./AutocompleteCountry";
import AutocompleteProvince from "./AutocompleteProvince";
import AutocompleteDepartament from "./AutocompleteDepartament";
import AutocompleteLocation from "./AutocompleteLocation";
import Pais from "domain/models/direcciones/Pais";
import Provincia from "domain/models/direcciones/Provincia";
import Partido from "domain/models/direcciones/Partido";
import Localidad from "domain/models/direcciones/Localidad";


export default function DireccionForm({direccion, onChange  } : { direccion: IDireccion, onChange: (e:any) => void}) {
    const [state, setState] = useState(direccion);

    const ChangeHandler = (e: any) => {
        var value = e.target.value;
        //value = (e.target.type === 'number') && +value ;
        value = (e.target.type === 'number' ?  +value : value );
        var objstate = {...state, [e.target.name]: value};
        setState(objstate);
        onChange({
            target : {
                name : "Direccion",
                value: objstate
            }
        });
    }

    const onChangeCountry = (value?: Pais | null) => {
        ChangeHandler({
            target : {
                name : "Pais",
                value: value
            }
        });
    }

    const onChangeProvince = (value?: Provincia | null) => {
        ChangeHandler({
            target : {
                name : "Provincia",
                value: value
            }
        });
    }

    const onChangeDepartment = (value?: Partido | null) => {
        ChangeHandler({
            target : {
                name : "Partido",
                value: value
            }
        });
    }

    const onChangeLocation = (value?: Localidad | null) => {
        ChangeHandler({
            target : {
                name : "Localidad",
                value: value
            }
        });
    }

    return (
        <Grid container>
            <Grid item xs={12} sm={12} md={12} lg={12} >
                Dirección:
            </Grid>
            <Grid item xs={12} sm={6} md={6} lg={6} >
                <AutocompleteCountry pais={state.Pais} onChange={onChangeCountry} ></AutocompleteCountry>
            </Grid>
            <Grid item xs={12} sm={6}  md={6} lg={6}>
                <AutocompleteProvince provincia={state.Provincia} pais={state.Pais} onChange={onChangeProvince}></AutocompleteProvince>
            </Grid>                
            <Grid item xs={12} sm={6} lg={6} >
                <AutocompleteDepartament partido={state.Partido} provincia={state.Provincia} onChange={onChangeDepartment}></AutocompleteDepartament>
            </Grid>
            <Grid item xs={12} sm={6} lg={6} >
                <AutocompleteLocation localidad={state.Localidad} partido={state.Partido} onChange={onChangeLocation}></AutocompleteLocation>
            </Grid>
            <Grid item xs={12} sm={6} lg={6} >
                <TextFiedl name="Calle" label="Calle" value={state.Calle} onChange={ChangeHandler}></TextFiedl>
            </Grid>
            <Grid item xs={12} sm={6} lg={6} >
                <TextFiedl name="NumeroCalle" type="number" label="Numero Calle" value={state.NumeroCalle} onChange={ChangeHandler}></TextFiedl>
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