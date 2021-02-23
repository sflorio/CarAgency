import React, { Component } from 'react'
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';

export default function AutocompleteConceptos() {
    const data = [
        { MarcaId: 1 , Descripcion: "Chapista Adelanto" },
        { MarcaId: 2 , Descripcion: "Chapista" },
        { MarcaId: 3 , Descripcion: "Lavado con motor" },
        { MarcaId: 4 , Descripcion: "Volante" }

    ];
    
    const labelName = "Concepto";

    return (
        <div>
             <Autocomplete
                id="AutocompleteConceptos"
                options={data}
                getOptionLabel={(option) => option.Descripcion}
                style={{ width: 300 }}
                renderInput={(params) => <TextField {...params} label={labelName} variant="outlined" />}
                />
        </div>
    )
}

