using Proyect.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proyect
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           // BindingContext = new MainPageViewModel();
        }

        private   void Button_Clicked(object sender, EventArgs e)
        {
            String sUsuario = txtUsuario.Text;
            String sPassword = txtPassword.Text;

            if ((sUsuario == "mariuxi") && (sPassword == "123"))
            {
                
                Navigation.PushAsync(new Login ());
                
            }
            else

            {

                string texto = txtUsuario.Text;
                string mensaje = "Estimad@,Usuario" + texto;
                DisplayAlert(mensaje, "Ingrese datos Válidos", "Gracias");


            }

        }

       

        private async  void btnRegistrarse_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrarse());
        }
    }
}
