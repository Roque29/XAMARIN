using System;
using System.Collections.Generic;
using System.Text;

namespace admision.vistaModelos
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    class LoginVistaModelo
    {
        public String txtUsuario { get; set; }
        public String txtClave { get; set; }
        public bool indicador { get; set; }
        
        public LoginVistaModelo()
        {
            this.indicador = false;
        }


        #region comandos
        public ICommand aceptarCommand {
            get
            {
                return new RelayCommand(aceptar);
            }

        }
        private async void aceptar()
        {
            if (string.IsNullOrEmpty(this.txtUsuario) || string.IsNullOrEmpty(this.txtClave))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Mensaje",
                    "Usuario y Clave son obligatorios",
                    "Aceptar");
                return;
            }

        }

        #endregion

    }
    
}
