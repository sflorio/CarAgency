import React, { Component } from 'react'
import PropTypes from 'prop-types'

import Dialog from "@material-ui/core/Dialog";
import DialogActions from "@material-ui/core/DialogActions";
import DialogContent from "@material-ui/core/DialogContent";
import DialogContentText from "@material-ui/core/DialogContentText";
import DialogTitle from "@material-ui/core/DialogTitle";
import Button from "@material-ui/core/Button";

interface Props{
    open: boolean,
    id: number,
    descripcion: string,
    entidad: string
}

interface State {
    open: boolean,
    id: number,
    descripcion: string,
    entidad: string
}

export default class DeleteDialog extends Component<Props, State> {
    
    constructor(props: Props) {
        super(props);
        this.state = {
            open: false,
            id: 0,
            descripcion: "",
            entidad: ""
        }
    }
    
    handleClose = () => {
        this.setState({open: false});
    };

    render() { 
        return (
            <div>
                <Dialog
                    open={this.props.open}                    
                    onClose={this.handleClose}
                    aria-labelledby="form-dialog-title">
                <DialogTitle id="form-dialog-title">Eliminar {this.props.entidad} ({this.props.id}) </DialogTitle>
                <DialogContent>
                    ¿Esta seguro que desea eliminar {this.props.entidad} ({this.props.id}) {this.props.descripcion} ?
                </DialogContent>
                <DialogActions>
                    <Button onClick={this.handleClose} color="primary">
                    Cancelar
                    </Button>
                    <Button /*onClick={this.handleSave}*/ color="primary">
                    Aceptar
                    </Button>
                </DialogActions>
                </Dialog>
            </div>
        )
    }
}
