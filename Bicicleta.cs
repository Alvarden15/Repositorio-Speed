using System;
using System.Collections.Generic;
using System.Text;

namespace Speed
{
    class Bicicleta :Vehiculo
    {
        public Bicicleta(int distancia) : base(distancia)
        {}

        public override void calcularTiempo()
        {
           tiempo = distancia/16 ;
        }

    }
}
