using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class ConversorTeX : ConversorTexto
    {
        public void converterCaractere()
        {
            Console.WriteLine("Caractere Tex");
        }

        public void converterFonte()
        {
            Console.WriteLine("Fonte Tex");
        }

        public void converterParagrafo()
        {
            Console.WriteLine("Paragrafo Tex");
        }
    }
}
