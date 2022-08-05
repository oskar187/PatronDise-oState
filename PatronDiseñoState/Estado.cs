using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseñoState
{
    public abstract class Estado
    {
        public abstract void ControladorEstado(Switch sw);
        public abstract string Describir();
    }
}
