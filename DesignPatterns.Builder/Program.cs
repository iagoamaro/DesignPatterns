using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorTexto conversor;
            var tipo = "";
            Console.WriteLine("Digite o tipo do arquivo");
            tipo = Console.ReadLine();
            if (tipo.Equals("pdf"))
            {
                conversor = new ConversorPDF();
            }
            else 
            {
                conversor = new ConversorTeX();
            }
            
            LeitorRTF leitor = new LeitorRTF(conversor);

            leitor.lerRTF();
            Console.ReadKey();
        }
    }
}
