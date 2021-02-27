using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impar_ou_Par
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            double soma = 0;
            double media = 0;
            double produto = 0;
            double diferenca = 0;

            Console.WriteLine("Escolha 3 numeros e veja");
            Console.Write("Digite o N1 = ");
            n1 = Convert.ToDouble(Console.ReadLine());
                if(n1%2==0){
                    Console.WriteLine(n1 + " é um numero par");
                }else{
                    Console.WriteLine(n1 + " é um numero impar");
                }
            Console.Write("Digite o valor de N2 = ");
            n2 = Convert.ToDouble(Console.ReadLine());
                if (n2 % 2 == 0){
                    Console.WriteLine(n2 + " é um numero par");
                }else{
                    Console.WriteLine(n2 + " é um numero impar");
                }
            Console.Write("digite o valor de N3 = ");
            n3 = Convert.ToDouble(Console.ReadLine());
                if (n3 % 2 == 0){
                    Console.WriteLine(n3 + " é um numero par");    
                }else{
                    Console.WriteLine(n3 + " é um numero impar");
                }

            Console.WriteLine("\n\nPara agregar sua exeperiencia\nIrei mostrar algumas contas possiveis com N1, N2, N3");
            soma = n1 + n2 + n3;
            Console.WriteLine("A soma dos 3 valores é de : " + soma);
            diferenca = n1 - n2 - n3;
            Console.WriteLine("A diferença entre os 3 valores é de : " + diferenca);
            produto = n1*n2*n3;
            Console.WriteLine("O produto dos 3 valores é de : " + produto);
            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("A media é de : " + media);
        }
    }
}
