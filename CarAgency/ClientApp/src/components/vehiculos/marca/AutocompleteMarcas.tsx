import React, { useState, useEffect} from 'react'
import Autocomplete from '@material-ui/lab/Autocomplete';
import * as MarcasStore from 'store/actions/Marcas';
import TextField from '@material-ui/core/TextField';
import {Marca} from "domain/models/vehiculos/Marca";

 function AutocompleteMarcas({marca ,onChange }: {marca: Marca, onChange: ( value: Marca | null) => void }) {
    const [options, setOptions] = React.useState<Marca[]>([]);
    const labelName = "Marca";

     useEffect(() => {
         MarcasStore.actionCreators.getAllMarcas()
         .then(response => response.data as unknown as Marca[] )
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
                // value={marca}
                getOptionLabel={(option) => option.Descripcion}
                getOptionSelected={(option, value) => {/*console.log({value,option});*/ return option.MarcaId === value.MarcaId;}}
                style={{ width: 300 }}
                renderInput={(params) => <TextField {...params} label={labelName} variant="outlined" />}
                />
        </div>
    )
}


export default AutocompleteMarcas;