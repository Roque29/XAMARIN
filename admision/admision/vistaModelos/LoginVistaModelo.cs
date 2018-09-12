using System;
using System.Collections.Generic;
using System.Text;

namespace admision.vistaModelos
{
    using GalaSoft.MvvmLight.Command;
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;

    class LoginVistaModelo : BaseVistaModelo
    {


        #region atributos
        private string txtClaveCambiar;
        private bool indicadorCambiar;
        #endregion

        #region propiedades 
        public String txtUsuario
        {
            get;
            set;
        }
        public String txtClave
        {
            get { return this.txtClaveCambiar; }
            set { SetValue(ref this.txtClaveCambiar,value); }
        }
        public bool indicador
        {
            get { return this.indicadorCambiar; }
            set { SetValue(ref this.indicadorCambiar, value); }
        }
        #endregion

        #region constructor
        public LoginVistaModelo()
        {
            this.txtUsuario = string.Empty;
            this.txtClave = string.Empty;
            this.indicador = false;
        }
        #endregion


        #region comandos
        public ICommand aceptarCommand
        {
            get
            {
                return new RelayCommand(aceptar);
            }

        }
        private async void aceptar()
        {
            this.indicador = true;
            if (string.IsNullOrEmpty(this.txtUsuario) || string.IsNullOrEmpty(this.txtClave))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "los campos usuario y clave son obligatorios",
                    "Aceptar");
                return;
            }

        }
        #endregion

    }

}
