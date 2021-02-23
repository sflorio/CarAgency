import * as React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../../store';
import * as ModeloStore from '../../store/Modelo';


import Button from "@material-ui/core/Button";
import TextField from "@material-ui/core/TextField";
import Dialog from "@material-ui/core/Dialog";
import DialogActions from "@material-ui/core/DialogActions";
import DialogContent from "@material-ui/core/DialogContent";
import DialogContentText from "@material-ui/core/DialogContentText";
import DialogTitle from "@material-ui/core/DialogTitle";
import Modelo from './Modelo';


interface Props {
    
}
interface State {
    
}

class modeloForm extends React.Component {
    state = {
        open: false,
        modelo: Modelo
      };
    
      // handleClose = () => {
      //   this.setState({open: false});
      // };
    
      // handleChange = name => event => {
      //   this.setState({
      //     article: event.target.value
      //   });
      // };
    
      // handleSave = () => {
          
      // };
    
      componentDidMount() {
        // this.setState({
        //   open: store.getState()["uiState"]["openFormDialog"]
        // });
    
        // store.subscribe(() => {
        //   console.log(
        //     "Form Dialog State" + JSON.stringify(store.getState()["uiState"])
        //   );
    
        //   this.setState({
        //     open: store.getState()["uiState"]["openFormDialog"]
        //   });
        // });
      }

    render() {
        return (
            <div>
                <Dialog
                    open={this.state.open}
                    //onClose={this.handleClose}
                    aria-labelledby="form-dialog-title">
                <DialogTitle id="form-dialog-title">Agregar Modelo</DialogTitle>
                <DialogContent>
                    <TextField
                    autoFocus
                    margin="dense"
                    id="descripcion"
                    label="Descripcion"
                    multiline
                    rowsMax="4"
                    rows="4"
                    fullWidth
                    //onChange={this.handleChange("multiline")}
                    />
                </DialogContent>
                <DialogActions>
                    <Button /*onClick={this.handleClose}*/ color="primary">
                    Cancel
                    </Button>
                    <Button /*onClick={this.handleSave}*/ color="primary">
                    Save
                    </Button>
                </DialogActions>
                </Dialog>
            </div>
        )
    }
}

export default modeloForm
