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
    public partial class InserPost : ContentPage
    {
        public InserPost()
        {
            InitializeComponent();
        }

        

        

        private async void btnInsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
             
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);

                cliente.UploadValues( "http://192.168.100.18/restaurante/cliente/post.php", "POS", parametros);

                await DisplayAlert("Alert", "Ingresado", "ok");


            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", ex.Message, "ok");
            }
        }

        private async void btnRegresar_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormularioLogin ());
        }
    }
}