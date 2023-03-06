using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_poo
{
    public class Program
    {
        public static void Main()
        {
            //Solicitar valores y almacenarlos 

            Console.WriteLine("Ingrese el valor 1");
            string value1 = Console.ReadLine();
            int value1Number = Int32.Parse(value1);

            Console.WriteLine("Ingrese el valor 2");
            string value2 = Console.ReadLine();
            int value2Number = Int32.Parse(value2);

            // Sumar los números
            Console.WriteLine("La suma de los números ingresado es:");
            Console.WriteLine(value1Number + value2Number);
            // Restar los números
            Console.WriteLine("La resta de los números ingresado es:");
            Console.WriteLine(value1Number - value2Number);
            // Multiplicar los números
            Console.WriteLine("La multiplicación de los números ingresado es:");
            Console.WriteLine(value1Number * value2Number);
            // Dividir los números
            Console.WriteLine("La división de los números ingresado es:");
            Console.WriteLine(value1Number / value2Number);

        }
    }
}
