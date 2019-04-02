using System;


namespace Divisionsin
{
    class Program
    {
        static void Main(string[] args)
        {/*Programa que pide dos números al usuario y realice la división
          sin utilizar el operador de división (/).*/
          //Declaraciondevariables
            Int32 divisor, dividendo, producto=1, resultado=0;
            //Entradadedatos
            Console.WriteLine("\n\tIngresa el valor del dividendo");
            dividendo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\tIngresa el valor del divisor");
            divisor = Convert.ToInt32(Console.ReadLine());
            //Proceso
            if (dividendo>=divisor)
            {
                while ((dividendo-divisor)>=resultado)
                {
                    resultado = divisor * producto;
                    producto++;
                }
                Console.WriteLine("El cociente es " + (producto - 1) + "el residuo es" + (dividendo-resultado));
            }
           
            //Salida
            //Pausa
            Console.WriteLine("\n\tPreiona cualquier tecla para continuar ");
            Console.ReadKey();

        }
    }
}
