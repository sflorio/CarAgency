import React, { useState, useEffect } from 'react';
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';
import Partido from "domain/models/direcciones/Partido";
import Provincia from "domain/models/direcciones/Provincia";
import * as DepartmentsStore from "store/actions/Departaments";

export default function AutocompleteCountry({ partido , provincia, onChange }: {partido: Partido, provincia: Provincia, onChange: ( value: Partido | null) => void }){
    const [options, setOptions] = React.useState<Partido[]>([]);
    const labelName = "Partido";

     useEffect(() => {
        DepartmentsStore.actionCreator.getAllDepartments(provincia.ProvinciaId)
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
                getOptionSelected={(option, value) => {return option.PartidoId === value.PartidoId;}}
                style={{ width: 300 }}
                renderInput={(params) => <TextField {...params} label={labelName} variant="outlined" />}
                />
        </div>
    )
}