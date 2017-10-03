using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente _cliente = new Cliente();
            _cliente.cirarDoc("DOCX");
            Console.ReadKey();
        }
    }
}
