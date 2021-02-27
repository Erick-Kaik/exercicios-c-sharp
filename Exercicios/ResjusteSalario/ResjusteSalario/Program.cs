using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResjusteSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double newSalario = 0;
            double aumento = 0;

            Console.WriteLine("Iremos fazer um reajuste salarial,\nconfira os novos valores a baixo");
            Console.WriteLine("Salarios de ate 300 reais há um aumento de 50%\nSalarios acima de 300 reais há um aumento de 30%");
                for(int i = 0; i <=10; i++){
                    Console.Write("Digite o novo valor: ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    if(salario <= 300){
                    aumento = (salario * 50) / 100;
                    newSalario = aumento + salario;
                    Console.WriteLine("O seu novo salario é de: " + newSalario);
                }else{
                    aumento = (salario * 30) / 100;
                    newSalario = aumento + salario;
                    Console.WriteLine("O seu novo salario é de: " + newSalario);
                }
                }
                
        }
    }
}
