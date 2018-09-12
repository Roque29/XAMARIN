using System;
using System.Collections.Generic;
using System.Text;

namespace admision.vistaModelos
{
    class MainVistaModelo
    {
        public LoginVistaModelo login { get; set; }
        public MainVistaModelo()
        {
            this.login = new LoginVistaModelo();
        }
    }
}
