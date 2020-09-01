import React from 'react';
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';

export default function AutocompleteTipoVehiculo() {
    const data = [
        { TipoVehiculoId: 1 , Descripcion: "Sedan" },
        { TipoVehiculoId: 2 , Descripcion: "Hatback" },
        { TipoVehiculoId: 3 , Descripcion: "Monovolumen" },
        { TipoVehiculoId: 4 , Descripcion: "Camión" }

    ];
    const labelName ="Tipo Vehículo";
    
    return (
        <div>
        <Autocomplete
           id="AutocompleteTipoVehiculo"
           options={data}
           getOptionLabel={(option) => option.Descripcion}
           style={{ width: 300 }}
           renderInput={(params) => <TextField {...params} label={labelName} variant="outlined" />}
           />
   </div>
    )
}
