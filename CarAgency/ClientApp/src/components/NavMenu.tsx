import * as React from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink , UncontrolledDropdown, DropdownToggle,DropdownMenu,DropdownItem} from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

export default class NavMenu extends React.PureComponent<{}, { isOpen: boolean }> {
    public state = {
        isOpen: false
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
                                <UncontrolledDropdown nav inNavbar>
                                <DropdownToggle nav caret>
                                    Vehiculos
                                </DropdownToggle>
                                <DropdownMenu right>
                                    <DropdownItem tag={Link} className="text-dark" to="/vehiculo/lista-vehiculos">
                                    Lista Vehiculos 
                                    </DropdownItem>
                                    <DropdownItem tag={Link} className="text-dark" to="/vehiculo/ingreso-vehiculo">
                                    Ingreso Vehiculos
                                    </DropdownItem>
                                </DropdownMenu>
                                </UncontrolledDropdown>
                                <UncontrolledDropdown nav inNavbar>
                                <DropdownToggle nav caret>
                                    Configuracion
                                </DropdownToggle>
                                <DropdownMenu right>
                                    <DropdownItem tag={Link} className="text-dark" to="/marca/lista-marcas">
                                    Marcas
                                    </DropdownItem>
                                    <DropdownItem tag={Link} className="text-dark" to="/modelo/lista-modelo">
                                    Modelos
                                    </DropdownItem>
                                    <DropdownItem tag={Link} className="text-dark" to="/personas/lista-estadoCivil">
                                    Estado Civil
                                    </DropdownItem>
                                </DropdownMenu>
                                </UncontrolledDropdown>
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
