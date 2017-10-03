using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public abstract class Documento : ICloneable
    {
        public Documento clone()
        {
            object clone = null;
            try
            {
                clone = MemberwiseClone();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
            Console.WriteLine("Documento tipo ."+ clone.GetType().Name);
            return (Documento)clone;
        }

    }
}
