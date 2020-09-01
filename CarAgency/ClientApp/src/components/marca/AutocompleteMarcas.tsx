import React, { Component } from 'react'
import Autocomplete from '@material-ui/lab/Autocomplete';
import * as MarcasStore from '../../store/Marcas';
import TextField from '@material-ui/core/TextField';

export default function AutocompleteMarcas() {
    const data = [
        { MarcaId: 1 , Descripcion: "Audi" },
        { MarcaId: 2 , Descripcion: "BMW" },
        { MarcaId: 3 , Descripcion: "Mercedez Benz" },
        { MarcaId: 4 , Descripcion: "VW" }

    ];
    
    const labelName = "Marca";

    return (
        <div>
             <Autocomplete
                id="AutocompleteMarcas"
                options={data}
                getOptionLabel={(option) => option.Descripcion}
                style={{ width: 300 }}
                renderInput={(params) => <TextField {...params} label={labelName} variant="outlined" />}
                />
        </div>
    )
}

