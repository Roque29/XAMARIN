using System;
using System.Collections.Generic;
using System.Text;

namespace admision.infraestructura
{   using vistaModelos;
    class InstanceLocator
    {
        public MainVistaModelo main { get; set; }

        public InstanceLocator()
        {
            this.main = new MainVistaModelo();
        }
    }
}
