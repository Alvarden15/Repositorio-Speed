namespace Speed
{
	class Vehiculo
	{
        public int distancia{get; set; }
        public string nombreVehiculo{ get; set;}
        public int tiempo{get; set;}

        public Vehiculo(int distancia){
            this.distancia= distancia;
           
        }

        public virtual void calcularTiempo()
        {

        }



	}
}
