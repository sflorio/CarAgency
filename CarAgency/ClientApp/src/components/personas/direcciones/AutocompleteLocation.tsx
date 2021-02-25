import React, { useState, useEffect } from 'react';
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';
import Localidad from "domain/models/direcciones/Localidad";
import Partido from "domain/models/direcciones/Partido";
import * as LocationsStore from "store/actions/Locations";

export default function AutocompleteLocation({localidad , partido, onChange }: {localidad: Localidad, partido: Partido, onChange: ( value: Localidad | null) => void }){
    const [options, setOptions] = React.useState<Localidad[]>([]);
    const labelName = "Localidad";

     useEffect(() => {
        LocationsStore.actionCreator.getAllLocations(partido.PartidoId)
         .then((response) => {
             setOptions(response);
         });
        
     },[]);

    return (
        <div>
            <Autocomplete
                id="AutocompleteMarcas"
                options={options}
                onChange={(event, value) => { onChange(value);}}
                getOptionLabel={(option) => option.Descripcion}
                getOptionSelected={(option, value) => {return option.LocalidadId === value.LocalidadId;}}
                style={{ width: 300 }}
                renderInput={(params) => <TextField {...params} label={labelName} variant="outlined" />}
                />
        </div>
    )
}