using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseñoState
{
    public class Apagado : Estado
    {
        public override void ControladorEstado(Switch sw)
        {
            sw.DefinirEstado(new StandBy());
        }

        public override string Describir()
        {
            return "Switch apagado";
        }
    }
}
