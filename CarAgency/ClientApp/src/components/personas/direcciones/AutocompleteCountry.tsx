import React, { useState, useEffect } from 'react';
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';
import Pais from "domain/models/direcciones/Pais";
import * as CountryStore from "store/actions/Countries";

export default function AutocompleteCountry({pais ,onChange }: {pais: Pais, onChange: ( value: Pais | null) => void }){
    const [options, setOptions] = React.useState<Pais[]>([]);
    const labelName = "Pais";

     useEffect(() => {
        CountryStore.actionCreator.getAllCountries()         
         .then((response) => { 
             setOptions(response);
         }) ;
        
     },[]);

    return (
        <div>
            <Autocomplete
                id="AutocompleteMarcas"
                options={options}
                onChange={(event, value) => { onChange(value);}}
                getOptionLabel={(option) => option.Descripcion}
                getOptionSelected={(option, value) => {return option.PaisId === value.PaisId;}}
                style={{ width: 300 }}
                renderInput={(params) => <TextField {...params} label={labelName} variant="outlined" />}
                />
        </div>
    )
}