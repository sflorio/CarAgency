import React, { useEffect } from 'react';
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';
import {actionCreatorsModelo} from 'store/actions/actionModelos';
import { Marca } from 'domain/models/vehiculos/Marca';
import { Modelo } from 'domain/models/vehiculos/Modelo';



export default function AutocompleteModelo({modelo, marca ,onChange }: {modelo: Modelo, marca: Marca, onChange: ( value: Modelo | null) => void }) {
    const [options, setOptions] = React.useState<Modelo[]>([]);
    
    const labelName = "Modelo";

     useEffect(() => {
        var id = 0;
        
        if( !(  marca == null)  ){
            id = ( marca.MarcaId == null ? 0 : marca.MarcaId );
        }

        actionCreatorsModelo.getAllModelos(id)
         .then((response) => { 
             setOptions(response);
         }) ;
        
     },[marca]);


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
