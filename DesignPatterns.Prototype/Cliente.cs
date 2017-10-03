using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    class Cliente
    {
        static string DocTipoPDF = "PDF";
        static string DocTipoDOCX = "DOCX";
        private Documento _pdf = new PDF();
        private Documento _docx = new DOCX();

        public Documento cirarDoc(string tipo)
        {
            if (tipo.Equals(DocTipoPDF))
            {
                return _pdf.clone();
            }
            else
            {
                return _docx.clone();
            }
            
        }
        

    }
}
