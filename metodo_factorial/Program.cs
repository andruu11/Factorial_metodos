using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_factorial
{
    class Program
    {
        static void Main(string[] args)
        {//metodo de ejecucion principal
            //Solicitamos un numero
            Console.WriteLine("Introduzca el numero del cual desea el factorial");
            int x = Convert.ToInt32(Console.ReadLine());//almacenamos el numero en una variable
            Console.WriteLine("El resultado es" + " " + Factorial(x));// imprimos resultado invocamos metodo(enviamos variable a ser operada)
            Console.ReadKey();

           
        }
        static int Factorial(int fact) {
            int resultado = 1;
            //algoritmo para hallar el factorial
            for (int i = 1; i <= fact; i++) {
                resultado *= i; //esto es igual a decir multiplicar = multiplicar * i
                                //es la version resumida
            }
            return resultado; // devolvemos nuestra variable resultado ante la invocacion de un metodo
        }
    }
}
