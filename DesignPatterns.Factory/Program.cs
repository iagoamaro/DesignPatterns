using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaAbstrata fabrica2 = new FabricaConcreta2();
            Cliente cliente2 = new Cliente(fabrica2);
            cliente2.executar();
            Console.ReadKey();

        }
    }
}
