import * as React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../store';
import * as MarcasStore from '../store/Marcas';
import { makeStyles } from '@material-ui/core/styles';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableContainer from '@material-ui/core/TableContainer';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import Paper from '@material-ui/core/Paper';

// At runtime, Redux will merge together...
type MarcasProps =
  MarcasStore.MarcaState // ... state we've requested from the Redux store
  & typeof MarcasStore.actionCreators // ... plus action creators we've requested
  & RouteComponentProps<{ startDateIndex: string }>; // ... plus incoming routing parameters

class ListaMarcas extends React.PureComponent<MarcasProps> {
  // This method is called when the component is first added to the document
  public componentDidMount() {
    this.ensureDataFetched();
  }

  // This method is called when the route parameters change
  public componentDidUpdate() {
    this.ensureDataFetched();
  }

  public render() {
    return (
      <React.Fragment>
        <h1 id="tabelLabel">Marcas</h1>
        <p>This component demonstrates fetching data from the server and working with URL parameters.</p>
        {this.renderTableMaterial()}
        {this.renderPagination()}
      </React.Fragment>
    );
  }

  private ensureDataFetched() {
    const startDateIndex = parseInt(this.props.match.params.startDateIndex, 10) || 0;
    this.props.requestMarcas(startDateIndex);
  }

  
  
  private renderTableMaterial(){

    return (
      <TableContainer component={Paper}>
        <Table  aria-label="simple table">
          <TableHead>
            <TableRow>
              <TableCell>Descripcion</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
          {this.props.marcas.map((marca: MarcasStore.Marca) =>
            <TableRow key={marca.marcaId}>
                  <TableCell component="th" scope="row">
                  {marca.descripcion}
                </TableCell>
            </TableRow>
          )}
          </TableBody>
        </Table>
      </TableContainer>
    );
  }

  private renderMarcasTable() {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Descripcion</th>
          </tr>
        </thead>
        <tbody>
          {this.props.marcas.map((marca: MarcasStore.Marca) =>
            <tr key={marca.marcaId}>
              <td>{marca.descripcion}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  private renderPagination() {
    const prevStartDateIndex = (this.props.startDateIndex || 0) - 5;
    const nextStartDateIndex = (this.props.startDateIndex || 0) + 5;

    return (
      <div className="d-flex justify-content-between">
        <Link className='btn btn-outline-secondary btn-sm' to={`/lista-marcas/${prevStartDateIndex}`}>Previous</Link>
        {this.props.isLoading && <span>Loading...</span>}
        <Link className='btn btn-outline-secondary btn-sm' to={`/lista-marcas/${nextStartDateIndex}`}>Next</Link>
      </div>
    );
  }
}

export default connect(
  (state: ApplicationState) => state.marcas, // Selects which state properties are merged into the component's props
  MarcasStore.actionCreators // Selects which action creators are merged into the component's props
)(ListaMarcas as any);
