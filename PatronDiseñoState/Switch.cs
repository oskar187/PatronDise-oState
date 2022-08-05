﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseñoState
{
    public class Switch
    {
        Estado _estado;
        public Switch()
        {
            _estado = new Encendido();
        }
        public void DefinirEstado(Estado estado)
        {
            _estado = estado;
        }
        public void Presionar()
        {
            _estado.ControladorEstado(this);
            Console.WriteLine(_estado.Describir());
        }
    }
}
