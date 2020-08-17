import React, { useState } from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../../store';
import * as MarcasStore from '../../store/Marcas';

import { makeStyles} from '@material-ui/core/styles';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableContainer from '@material-ui/core/TableContainer';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import TableFooter from '@material-ui/core/TableFooter';
import TablePagination from '@material-ui/core/TablePagination';
import Paper from '@material-ui/core/Paper';
import { Button } from 'reactstrap';


import MaterialTable, { Column } from 'material-table';






//other custom components
//import DeleteDialog from 'components/common/dialogs/DeleteDialog';
import InlineDeleteButton from 'components/common/tables/tableElement/InlineDeleteButton';
import CustomTablePagination from 'components/common/tables/tableElement/CustomTablePagination';

// At runtime, Redux will merge together...
type MarcasProps =
  MarcasStore.MarcaState // ... state we've requested from the Redux store
  & typeof MarcasStore.actionCreators // ... plus action creators we've requested
  & RouteComponentProps<{ startDateIndex: string }>; // ... plus incoming routing parameters

const useStyles2 = makeStyles({
  table: {
    minWidth: 500,
  },
});


class ListaMarcas extends React.Component<MarcasProps> {
  
  private getRowsPerPage = () =>{
    return ( this.props.rowsPerPage == undefined ? 0 : this.props.rowsPerPage );

  };

  private getPage = () => {
    return (this.props.page == undefined ? 0 : this.props.page);
  };

  emptyRows = this.getRowsPerPage() - Math.min(this.getRowsPerPage(), this.props.marcas.length - this.getPage() * this.getRowsPerPage());

  handleChangePage = (event: React.MouseEvent<HTMLButtonElement> | null, newPage: number) => {
    this.state = {page : newPage};
  };

  handleChangeRowsPerPage = (
    event: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>,
  ) => {
    this.state = {
      rowsPerPage: parseInt(event.target.value, 10),
      page: 0}
    ;
  };



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
        {/* <Button onClick={this.onButtonClick} >Boton</Button> */}
      </React.Fragment>
    );
  }

  private ensureDataFetched() {
    const startDateIndex = ( this.getPage() -1 ) * ( this.getRowsPerPage() + 1 );
    this.props.requestMarcas(startDateIndex);
  }

  private renderTableMaterial(){
    return (
      <TableContainer component={Paper}>
        <Table  aria-label="custom pagination table">
          <TableBody>
            {this.props.marcas.map((marca: MarcasStore.Marca) => (
              <TableRow key={marca.marcaId}>
                <TableCell component="th" scope="row">
                {marca.descripcion}
                </TableCell>
                <TableCell component="th" scope="row">
                <InlineDeleteButton id={(marca.marcaId == null ? 0 : marca.marcaId)} descripcion={marca.descripcion} entidad="Marca" open={false}  ></InlineDeleteButton>
                </TableCell>
              </TableRow>
            ))}
            {this.emptyRows > 0 && (
              <TableRow style={{ height: 53 * this.emptyRows }}>
                <TableCell colSpan={6} />
              </TableRow>
            )}
          </TableBody>
          <TableFooter>
            <TableRow>
              <TablePagination
                rowsPerPageOptions={[5, 10, 25, { label: 'All', value: -1 }]}
                colSpan={3}
                count={this.props.marcas.length}
                rowsPerPage={this.getRowsPerPage()}
                page={this.getPage()}
                SelectProps={{
                  inputProps: { 'aria-label': 'rows per page' },
                  native: true,
                }}
                onChangePage={this.handleChangePage}
                onChangeRowsPerPage={this.handleChangeRowsPerPage}
                ActionsComponent={CustomTablePagination}
              />
            </TableRow>
          </TableFooter>
        </Table>
      </TableContainer>
    );
  }
}

export default connect(
  (state: ApplicationState) => state.marcas, // Selects which state properties are merged into the component's props
  MarcasStore.actionCreators // Selects which action creators are merged into the component's props
)(ListaMarcas as any);
