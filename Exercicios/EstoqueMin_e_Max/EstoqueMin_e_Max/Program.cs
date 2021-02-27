using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueMin_e_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int produto = 0;
            double valor = 2.50;
            double total = 0;
            int diferenca = 0;

            Console.WriteLine("Você tem q reabastercer um deposito com um certo produto");
            Console.WriteLine("porem você tera que trazer uma quantidade entre 50 unidades ate 250 unidades");
            Console.Write("Você comprou: ");
            produto = Convert.ToInt32(Console.ReadLine());
            if (produto >= 50 && produto <= 250)
            {
                Console.WriteLine("Você abasteceu o estoque com " + produto + " unidades.");
                total = Convert.ToDouble(produto * valor);
                Console.Write("O valor da compra deu: " + total + "\n");
            }
            else{
                if (produto <= 50){
                    diferenca = 50 - produto;
                    Console.WriteLine("Você comprou uma quantidade diferente do combinado");
                    Console.WriteLine("trazendo uma diferença de " + diferenca + " unidades, uma quantidade abaixo do esperado");
                }else{
                    diferenca = produto - 250;
                    Console.WriteLine("Você comprou uma quantidade diferente do combinado");
                    Console.WriteLine("assim trouxe " + diferenca + " a mais que o necessario");
                }
            }
        }
        }
    }

