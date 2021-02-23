import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import ListaMarcas from "./components/marca/Marca"
import ListaVehiculos from "components/vehiculo/Vehiculo";
import IngresoVehiculo from 'components/vehiculo/IngresoVehiculo';
import ListaEstadosCiviles from "components/personas/EstadoCivil";
import ListaModelo from 'components/modelo/Modelo';
import './custom.css'

export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/marca/lista-marcas/:startDateIndex?' component={ListaMarcas} />
        <Route path='/vehiculo/lista-vehiculos/:startDateIndex?' component={ListaVehiculos} />
        <Route path='/vehiculo/ingreso-vehiculo' component={IngresoVehiculo} />
        <Route path='/personas/lista-estadoCivil' component={ListaEstadosCiviles} />
        <Route path='/modelo/lista-modelo' component={ListaModelo} />


    </Layout>
);