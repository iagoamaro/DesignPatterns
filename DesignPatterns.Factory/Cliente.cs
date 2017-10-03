using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Cliente
    {
        private ProdutoAbstratoA produtoA;
        private ProdutoAbstratoB produtoB;
         
        public Cliente(FabricaAbstrata fabrica)
        {
            produtoA = fabrica.createProdutoA();
            produtoB = fabrica.createProdutoB();
        }

        public void executar()
        {
            produtoB.interagir(produtoA);
        }
    }
}
