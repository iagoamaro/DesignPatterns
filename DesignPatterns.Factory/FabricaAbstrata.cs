﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public interface FabricaAbstrata
    {
        ProdutoAbstratoA createProdutoA();
        ProdutoAbstratoB createProdutoB();
    }
}
