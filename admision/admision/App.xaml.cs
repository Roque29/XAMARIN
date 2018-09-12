using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace admision
{
    using vistas;
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            this.MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep() //cuando cambias a otra aplicación
        {
            // Handle when your app sleeps
        }

        protected override void OnResume() //cuando vuelves a la aplicación
        {
            // Handle when your app resumes
        }
    }
}
