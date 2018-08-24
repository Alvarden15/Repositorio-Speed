using System;
using System.Collections.Generic;
using System.Text;

namespace Speed
{
    class Motocicleta : Vehiculo
    {
        public Motocicleta(int distancia) : base(distancia){
         }

        public override void calcularTiempo()
        {
           tiempo= distancia/80;
        }

    }
}
