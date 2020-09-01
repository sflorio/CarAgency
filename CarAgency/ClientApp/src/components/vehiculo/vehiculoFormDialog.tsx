import React, {useState} from 'react';
import Button from '@material-ui/core/Button';
import TextField from '@material-ui/core/TextField';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogContentText from '@material-ui/core/DialogContentText';
import DialogTitle from '@material-ui/core/DialogTitle';

import VehiculoForm from './vehiculoForm';
 
interface props{
    open: boolean
}
interface state extends props{

}
export default class vehiculoFormDialog extends React.Component<props,state> {
    constructor(props : props) {
        super(props);
        this.state = { ...props };
    }
  
  handleClickOpen = () => {
    this.setOpen(true);
  };

  setOpen = (open: boolean) =>{
    this.setState({ open: open });
  }

  handleClose= () => {
    this.setOpen(false);
  };

  render(){
    return (
        <div>
        <Button variant="outlined" color="primary" onClick={this.handleClickOpen}>
            Open form dialog
        </Button>
        <Dialog open={this.state.open} onClose={this.handleClose} aria-labelledby="form-dialog-title">
            <DialogTitle id="form-dialog-title">Subscribe</DialogTitle>
            <DialogContent>
            <DialogContentText>
                To subscribe to this website, please enter your email address here. We will send updates
                occasionally.
            </DialogContentText>
                <VehiculoForm></VehiculoForm>
            </DialogContent>
            <DialogActions>
            <Button onClick={this.handleClose} color="primary">
                Salir
            </Button>
            <Button onClick={this.handleClose} color="primary">
                Guardar
            </Button>
            </DialogActions>
        </Dialog>
        </div>
    );
  }
}