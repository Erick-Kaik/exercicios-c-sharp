using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_5_Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            double joao = 0;
            double maria = 0;
            double fernando = 0;
            double vitoria = 0;
            double larissa = 0;
            double media = 0;

            Console.WriteLine("Calcule a idade media de 5 alunos");
            Console.Write("Digite a idade do João: ");
            joao = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a idade de Maria: ");
            maria = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a idade de Fernando: ");  
            fernando = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a idade de Vitoria: ");
            vitoria = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a idade de Larissa: ");
            larissa = Convert.ToDouble(Console.ReadLine());
            media = (joao+maria+fernando)/2;
            Console.WriteLine("A idade media dos 5 alunos é de: " + media);

        }
    }
}
