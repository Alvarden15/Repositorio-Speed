using System;
using System.Collections.Generic;
using System.Text;

namespace Speed
{
    class Automovil : Vehiculo
    {

        public Automovil(int distancia) : base(distancia){
        }


        public override void calcularTiempo()
        {
            tiempo = distancia/160;
        }

    }
}
