using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyect
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrarse : ContentPage
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private async void btnInsertar_Clicked(object sender, EventArgs e)
        {

            try
            {
                WebClient cliente = new WebClient();
                var parametro = new System.Collections.Specialized.NameValueCollection();

                parametro.Add("usuario", txtusuario.Text);
                parametro.Add("password", txtpassword.Text);

                cliente.UploadValues("http://198.168.100.18/restaurante/login/post.php", "POS", parametro);
                //  await DisplayAlert("Alerta", "Ingresado", "ok");
                //txtCodigo.Text = "";
                
                var mensaje = "Dato ingresado con éxito";
                DependencyService.Get<Mensaje>().longAlert(mensaje);
                txtusuario.Text = "";
                txtpassword.Text = "";
               await Navigation.PushAsync(new MainPage());
            }
            catch(Exception ex) 
            {
                DependencyService.Get<Mensaje>().ShortAlert(ex.ToString());

               // await DisplayAlert("Error", ex.Message, "ok");
                txtusuario.Text = "";               
                txtpassword.Text = "";
                

            }
        }

        private async void btnRegresar_Clicked(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new MainPage());
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {

        }

        

        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            //Formulario login
            await Navigation.PushAsync(new FormularioLogin());
        }
    }
}