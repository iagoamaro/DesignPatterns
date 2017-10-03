using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class LeitorRTF
    {
        private ConversorTexto conversor;

        public LeitorRTF(ConversorTexto c)
        {
            conversor = c;
        }
        public void lerRTF()
        {
            conversor.converterCaractere();
            conversor.converterFonte();
            conversor.converterParagrafo();

        }
    }
}
