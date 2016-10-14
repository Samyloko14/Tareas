using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_samy
{
    public class Program
    {
        static void Main(string[] args)
        {
            string linea;
            string Nombre;
            int Edad = 0;
            double Salario = 0;
            

            Console.WriteLine("Ingrese nombre : ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad: ");
            linea = Console.ReadLine();
            Edad = int.Parse(linea);
            Console.WriteLine("ingrese Salario: ");
            linea = Console.ReadLine();
            Salario = float.Parse(linea);
            if (Salario >= 10000)
            {
                double iva = Salario * 0.20;
                double SueldoFinal = Salario - iva;
                Console.Write("sueldo final: ");
                Console.Write(SueldoFinal);
            }
            else
            {
                double iva = Salario * 0.16;
                double SueldoFinal = Salario - iva;
                Console.Write("sueldo final: ");
                Console.Write(SueldoFinal);
            }
            Console.ReadKey();
        }
    }
}
