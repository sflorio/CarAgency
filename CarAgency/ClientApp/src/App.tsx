import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import ListaMarcas from "components/vehiculos/marca/Marca"
import ListaVehiculos from "components/vehiculos/vehiculo/Vehiculo";
import IngresoVehiculo from "components/vehiculos/vehiculo/IngresoVehiculo";
import ListaEstadosCiviles from "components/personas/EstadoCivil";
import './custom.css'

export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/marca/lista-marcas/:startDateIndex?' component={ListaMarcas} />
        <Route path='/vehiculo/lista-vehiculos/:startDateIndex?' component={ListaVehiculos} />
        <Route path='/vehiculo/ingreso-vehiculo' component={IngresoVehiculo} />
        <Route path='/configuracion/lista-estadoCivil/:startDateIndex?' component={ListaEstadosCiviles} />

    </Layout>
);