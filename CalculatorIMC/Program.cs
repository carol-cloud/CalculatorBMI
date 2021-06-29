using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu peso em Kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a sua altura em M: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> Magreza");
            } 
            else if ((valorIMC >= 20) && (valorIMC <= 24))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> Normal");
            } 
            else if ((valorIMC >= 25) && (valorIMC <= 29))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> Sobrepeso");
            } 
            else if ((valorIMC >= 30) && (valorIMC <= 35))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> Obesidade");
            } 
            else
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> Obesidade Grave");
            }

            Console.ReadKey();
        }
    }
}
