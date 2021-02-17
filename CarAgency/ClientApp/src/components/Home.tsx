import * as React from 'react';
import { connect } from 'react-redux';

const Home = () => (
  <div>
    <h1>Liv Motors</h1>    
    <p>Bienvendio al sistema de administación de Liv Motors</p>
   </div>
);

export default connect()(Home);
