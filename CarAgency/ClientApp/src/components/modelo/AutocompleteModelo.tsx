import React from 'react';
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';

export default function AutocompleteModelo() {
    const data = [
        { ModeloId: 1 , MarcaId: 1,  Descripcion: "A1" },
        { ModeloId: 2 , MarcaId: 1,  Descripcion: "A3" },
        { ModeloId: 3 , MarcaId: 1,  Descripcion: "A4" },
        { ModeloId: 4 , MarcaId: 1,  Descripcion: "TT" },
        { ModeloId: 5 , MarcaId: 2,  Descripcion: "328" }

    ];
    const labelName = "Modelo";
    return (
        <div>
             <Autocomplete
                id="AutocompleteModelos"
                options={data}
                getOptionLabel={(option) => option.Descripcion}
                style={{ width: 300 }}
                renderInput={(params) => <TextField {...params} label={labelName} variant="outlined" />}
                />
        </div>
    )
}
