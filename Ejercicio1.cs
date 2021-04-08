using System;

namespace Tutoria;

Class Ejercicio1{
    public static void main(){
        Ticket a = new Ticket(1,1);
        Console.WriteLine(a.obtenerprecio);
    }
}

Class Ticket{
    private int numerocorrelativo,cantidad;

    public Ticket(int numerocorrelativo, int cantidad){
        this.numerocorrelativo=numerocorrelativo;
        this.cantidad=cantidad;
    }

    public int obtenerprecio(){
        if(numerocorrelativo==1){
            return(2240*cantidad);
        }
        else if(numerocorrelativo>=2 && numerocorrelativo<=12){
            return(960*cantidad);
        }
        else if(numerocorrelativo>=13 && numerocorrelativo<=14){
            return(2240*cantidad);
        }
        else if(numerocorrelativo==15){
            return(960*cantidad);
        }
        else if(numerocorrelativo==16){
            return(2560*cantidad);
        }
    }
}
