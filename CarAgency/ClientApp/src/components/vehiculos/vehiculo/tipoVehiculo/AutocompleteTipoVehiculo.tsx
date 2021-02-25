import React, { useEffect } from 'react';
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';
import { actionCreatorsTipoVehiculo } from 'store/actions/actionsTipoVehiculo';
import { TipoVehiculo } from 'domain/models/vehiculos/TipoVehiculo';

export default function AutocompleteTipoVehiculo({tipoVehiculo ,onChange }: {tipoVehiculo: TipoVehiculo, onChange: ( value: TipoVehiculo | null) => void }) {
    const [options, setOptions] = React.useState<TipoVehiculo[]>([]);
    const labelName ="Tipo Vehículo";
    
     useEffect(() => {
         actionCreatorsTipoVehiculo.getAllTipoVehiculos()
         .then((response: TipoVehiculo[]) =>{
            setOptions(response);
         });
        
     },[]);
     
    
    
    return (
        <div>
        <Autocomplete
           id="AutocompleteTipoVehiculo"
           options={options}
           onChange={(event, value) => { onChange(value);}}
           // value={marca}
           getOptionLabel={(option) => option.Descripcion}
           getOptionSelected={(option, value) => {/*console.log({value,option});*/ return option.TipoVehiculoId === value.TipoVehiculoId;}}
           style={{ width: 300 }}
           renderInput={(params) => <TextField {...params} label={labelName} variant="outlined" />}
           />
   </div>
    )
}
