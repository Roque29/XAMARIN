using System;
using System.Collections.Generic;
using System.Text;

namespace admision.vistaModelos
{
    using System.Windows.Input;
    class LoginVistaModelo
    {
        public String txtUsuario { get; set; }
        public String txtClave { get; set; }
        public bool indicador { get; set; }
        public ICommand btnAceptar { get; set; }
        public LoginVistaModelo()
        {
            this.indicador = false;
        }

        

    }
}
