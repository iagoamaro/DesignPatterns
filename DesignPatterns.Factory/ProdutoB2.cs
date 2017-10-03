using System;

namespace DesignPatterns.Factory
{
    internal class ProdutoB2 : ProdutoAbstratoB
    {
        public void interagir(ProdutoAbstratoA a)
        {
            Console.WriteLine(this.GetType().Name + " interage com " + a.GetType().Name);
        }
    }
}