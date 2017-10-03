using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class FabricaConcreta2 : FabricaAbstrata
    {
        public ProdutoAbstratoA createProdutoA()
        {
            return new ProdutoA2();
        }

        public ProdutoAbstratoB createProdutoB()
        {
            return new ProdutoB2();
        }
    }
}
