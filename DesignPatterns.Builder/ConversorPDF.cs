using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class ConversorPDF : ConversorTexto
    {
        public void converterCaractere()
        {
            Console.WriteLine("Caractere PDF");
        }

        public void converterFonte()
        {
            Console.WriteLine("Fonte PDF");
        }

        public void converterParagrafo()
        {
            Console.WriteLine("Paragrafo PDF");
        }
    }
}
