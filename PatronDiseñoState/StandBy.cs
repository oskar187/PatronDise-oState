using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseñoState
{
    public class StandBy : Estado
    {
        public override void ControladorEstado(Switch sw)
        {
            sw.DefinirEstado(new Encendido());
        }

        public override string Describir()
        {
            return "Switch en stand by";
        }
    }
}
