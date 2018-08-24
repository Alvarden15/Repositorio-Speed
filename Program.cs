using System;
using System.Threading;

namespace Speed
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Buenas, quien quiera que seas");
            String res="S";
            Vehiculo v= null;
            int conteo = 0;
            
            do{

			Console.WriteLine("Ingrese Distancia (Km):");
             Int32 dist = Convert.ToInt32(Console.ReadLine());
               

			Console.WriteLine("Ingrese Vehiculo: ");
                Console.WriteLine("A/M/B");
                Console.WriteLine("Glosario (por si las moscas):");
                Console.WriteLine("A=Automovil");
                Console.WriteLine("M=Motocicleta");
                Console.WriteLine("B=Bicicleta");
                String ve= Convert.ToString(Console.ReadLine());


                while (!ve.Equals("a", StringComparison.OrdinalIgnoreCase) 
                    && !ve.Equals("b", StringComparison.OrdinalIgnoreCase) 
                    && !ve.Equals("m", StringComparison.OrdinalIgnoreCase))
                {
                    if (conteo<5)
                    {
                        Console.WriteLine("No disponible. Lo sentimos. Por favor, eliga una de las opciones disponibles");
                       
                    }
                    else if(conteo<15){
                        Console.WriteLine("Ejemm..., por si no te has percatado, solo tenemos 3 opciones");
                        Thread.Sleep(500);
                    }
                    else {
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        Console.WriteLine("Esto no es por molestar, verdad?");
                        Thread.Sleep(1000);
                        Console.WriteLine("¡Elige uno de los tres!");

                    }
                    Console.WriteLine("A/M/B");
                    ve = Convert.ToString(Console.ReadLine());
                    conteo++;

                }
            switch(ve){
            case "A":
            case "a":
                      
                {
                   v= new Automovil(dist) ;
                            v.calcularTiempo();
                            Console.WriteLine("El tiempo estimado es {0} horas", v.tiempo);
                            break;}
            case "B": 
            case "b":            
               {     
                 v= new Bicicleta(dist)   ;
                            v.calcularTiempo();
                            Console.WriteLine("El tiempo estimado es {0} horas", v.tiempo);
                            break;}
            case "M":
            case "m":
                {     
                   v= new Motocicleta(dist);
                            v.calcularTiempo();
                            Console.WriteLine("El tiempo estimado es {0} horas", v.tiempo);
                            break;}
            
                      
            }
                


                Console.WriteLine("Quieres continuar? S/N");
                res = Convert.ToString(Console.ReadLine());
                }while(!res.Equals("N",StringComparison.OrdinalIgnoreCase));


		}
	}
}
