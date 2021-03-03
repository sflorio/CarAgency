import React, { useEffect } from 'react';
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';
import {actionCreators} from 'store/actions/Procedencias';
import Procedencia from 'domain/models/vehiculos/Procedencia';


export default function AutocompleteProcedencia({procedencia, onChange }: {procedencia: Procedencia, onChange: ( value: Procedencia | null) => void }) {
    const [options, setOptions] = React.useState<Procedencia[]>([]);
    
    const labelName = "Procedencia";

     useEffect(() => {
        actionCreators.getAllProcedencias()
         .then((response) => { 
             setOptions(response);
         }) ;
     },[]);

    return (
        <div>
             <Autocomplete
                id="AutocompleteProcedencias"
                options={options}
                onChange={(event, value) => { onChange(value);}}                
                // value={marca}
                getOptionLabel={(option) => option.Descripcion}
                getOptionSelected={(option, value) => { return option.ProcedenciaId === value.ProcedenciaId;}}
                style={{ width: 300 }}
                renderInput={(params) => <TextField {...params} label={labelName} variant="outlined" />}
                />
        </div>
    )
}
