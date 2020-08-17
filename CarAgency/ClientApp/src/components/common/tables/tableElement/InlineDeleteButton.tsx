import React from 'react';

import Button from "@material-ui/core/Button";

//Custom Components"
import DeleteDialog from "components/common/dialogs/DeleteDialog";

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

export default class InlineDeleteButton extends React.Component<Props, State>{
    constructor(props: Props) {
        super(props);
        this.state = {
            open: false,
            id: 0,
            descripcion: "",
            entidad: ""   
        };
        this.handleOnClick.bind(this);
    }

    setOpenTrue =() =>{
        this.setState({
            open: true
        });
    }
       

    handleOnClick = () =>{
        console.log("hizo click en el boton " + this.state.descripcion)
        this.setOpenTrue();
        console.log("hizo click en el boton " + this.state.open)
    };

    render() {
        return (
            <div>
                <Button onClick={this.handleOnClick} >Delete</Button>
                <DeleteDialog 
                    open={this.state.open}
                    id={this.state.id}
                    descripcion={this.state.descripcion}
                    entidad={this.state.entidad}
                ></DeleteDialog>
            </div>
        )
    }
}
