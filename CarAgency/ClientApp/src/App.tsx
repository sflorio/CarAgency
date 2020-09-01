import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
import ListaMarcas from "./components/marca/Marca"
import ListaVehiculos from "components/vehiculo/Vehiculo";
import IngresoVehiculo from 'components/vehiculo/IngresoVehiculo';
import './custom.css'

export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data/:startDateIndex?' component={FetchData} />
        <Route path='/marca/lista-marcas/:startDateIndex?' component={ListaMarcas} />
        <Route path='/vehiculo/lista-vehiculos/:startDateIndex?' component={ListaVehiculos} />
        <Route path='/vehiculo/ingreso-vehiculo' component={IngresoVehiculo} />
    </Layout>
);