import React, { useState, useEffect } from 'react';
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';
import Provincia from "domain/models/direcciones/Provincia";
import Pais from "domain/models/direcciones/Pais";
import * as ProvincesStore from "store/actions/Provinces";

export default function AutocompleteLocation({provincia , pais, onChange }: {provincia: Provincia, pais: Pais, onChange: ( value: Provincia | null) => void }){
    const [options, setOptions] = React.useState<Provincia[]>([]);
    const labelName = "Provicia";

     useEffect(() => {
        ProvincesStore.actionCreator.getAllProvinces(pais.PaisId)
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
                getOptionSelected={(option, value) => {return option.ProvinciaId === value.ProvinciaId;}}
                style={{ width: 300 }}
                renderInput={(params) => <TextField {...params} label={labelName} variant="outlined" />}
                />
        </div>
    )
}