using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificador__de_maior_de_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int pessoas = 0;
            int idade = 0;

            Console.WriteLine("Iremos verificar quantas pessoas são maiores de idade");
                for(int i = 1; i <= 10; i++){
                Console.Write("Informe a idade das pessoas: ");
                idade = Convert.ToInt32(Console.ReadLine());
                if(idade >= 18){
                    pessoas++;
                }
                Console.WriteLine("Há " + pessoas + " que são maiores de idade");
            }
        }
    }
}
