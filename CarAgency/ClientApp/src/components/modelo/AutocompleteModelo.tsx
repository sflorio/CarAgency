import React, { useEffect } from 'react';
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';
import {actionCreatorsModelo} from 'store/actions/actionModelos';
import { Modelo } from 'models/Modelo';


export default function AutocompleteModelo({modelo ,onChange }: {modelo: Modelo, onChange: ( value: Modelo | null) => void }) {
    const [options, setOptions] = React.useState<Modelo[]>([]);
    const labelName = "Modelo";

     useEffect(() => {
        actionCreatorsModelo.getAllModelos()
         .then((response) => { 
             setOptions(response);
         }) ;
        
     },[]);


    return (
        <div>
             <Autocomplete
                id="AutocompleteModelos"
                options={options}
                onChange={(event, value) => { onChange(value);}}                
                // value={marca}
                getOptionLabel={(option) => option.Descripcion}
                getOptionSelected={(option, value) => {/*console.log({value,option});*/ return option.ModeloId === value.ModeloId;}}
                style={{ width: 300 }}
                renderInput={(params) => <TextField {...params} label={labelName} variant="outlined" />}
                />
        </div>
    )
}
