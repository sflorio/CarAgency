import * as React from 'react';
import { useState } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';
import Dropdown from './dropdown/Dropdown';





export default class NavMenu extends React.PureComponent<{}, { isOpen: boolean ,dropdown : boolean}> {
    public state = {
        isOpen: false,
        dropdown: false
    };



onMouseEnter = () => {
    if (window.innerWidth < 960) {
        this.setState({...this.state,dropdown:false});
    } else {
        this.setState({...this.state,dropdown:true});
    }
};

onMouseLeave = () => {
    if (window.innerWidth < 960) {
        this.setState({...this.state,dropdown:false});
    } else {
        this.setState({...this.state,dropdown:false});
    }
};


    public render() {
        return (
            <header>
                <Navbar className="navbar-expand-sm navbar-toggleable-sm border-bottom box-shadow mb-3" light>
                    <Container>
                        <NavbarBrand tag={Link} to="/">Liv Motors</NavbarBrand>
                        <NavbarToggler onClick={this.toggle} className="mr-2"/>
                        <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={this.state.isOpen} navbar>
                            <ul className="navbar-nav flex-grow">
                                <NavItem>
                                    <NavLink tag={Link} className="text-dark" to="/">Home</NavLink>
                                </NavItem>
                                <NavItem >
                                    <NavLink tag = {Link} className="text-dark" to="/vehiculo/lista-vehiculos" onMouseEnter={this.onMouseEnter} onMouseLeave={this.onMouseLeave}>Vehiculos <i className='fas fa-caret-down' /></NavLink>
                                {(this.state.dropdown ? <Dropdown /> : "")}
                                </NavItem>
                                <NavItem>
                                    <NavLink tag={Link} className="text-dark" to="/marca/lista-marcas">Lista Marcas</NavLink>
                                </NavItem>
                                <NavItem>
                                    <NavLink tag={Link} className="text-dark" to="/vehiculo/lista-vehiculos">Lista Vehiculos</NavLink>
                                </NavItem>
                                <NavItem>
                                    <NavLink tag={Link} className="text-dark" to="/vehiculo/ingreso-vehiculo">Ingreso Vehiculos</NavLink>
                                </NavItem>
                                <NavItem>
                                    <NavLink tag={Link} className="text-dark" to="/personas/lista-estadoCivil">Estado Civil</NavLink>
                                </NavItem>
                            </ul>
                        </Collapse>
                    </Container>
                </Navbar>
            </header>
        );
    }

    private toggle = () => {
        this.setState({
            isOpen: !this.state.isOpen
        });
    }
}
