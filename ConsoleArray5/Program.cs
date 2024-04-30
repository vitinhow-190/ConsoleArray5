using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nome = new string[5];
            Double[] peso = new Double[5];
            Double[] altura = new Double[5];
            Double[] imc = new Double[5];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Informe seu nome: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Informe seu peso: ");
                peso[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe sua altura: ");
                altura[i] = double.Parse(Console.ReadLine());

                imc[i] = peso[i] / (altura[i] * altura[i]);



                if (imc[i] <= 18.5)
                {
                    Console.WriteLine("Abaixo do peso.");
                }
                else if (imc[i] <= 24.9)
                {
                    Console.WriteLine("Peso ideal!!");
                }
                else if (imc[i] <= 29.9)
                {
                    Console.WriteLine("Levemente acima do peso.");
                }
                else if (imc[i] <= 34.9)
                {
                    Console.WriteLine("Obesidade grau I.");
                }
                else if (imc[i] <= 39.9)
                {
                    Console.WriteLine("Obesidade grau II.");
                }
                else if (imc[i] > 40)
                {
                    Console.WriteLine("Obesidade grau III");
                }


            }
            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine(" Nome: " + nome[j] + " Peso: " + peso[j] + " Altura: " + altura[j] + "imc: " + imc[j]);
            }


            Console.ReadKey();
        }
    }
}
