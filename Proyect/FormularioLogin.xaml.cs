using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyect
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class FormularioLogin : ContentPage
    {
        private const string Url = "http://192.168.100.18/restaurante/cliente/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Proyect.ViewModels.Datos> _post;

        public FormularioLogin()
        {

            InitializeComponent();
            select();
        }
         public async void select()
        {
            var content = await client.GetStringAsync(Url);
            List<Proyect.ViewModels.Datos> posts = JsonConvert.DeserializeObject<List<Proyect.ViewModels.Datos>>(content);
            _post = new ObservableCollection<Proyect.ViewModels.Datos>(posts);

            MyListView.ItemsSource = _post;

        }
        

        //private async void btnGet_Clicked(object sender, EventArgs e)
        //{
          //  var content = await client.GetStringAsync(Url);
            //List<Proyect.ViewModels.Datos> posts = JsonConvert.DeserializeObject<List<Proyect.ViewModels.Datos>>(content);
            //_post = new ObservableCollection<Proyect.ViewModels.Datos>(posts);

             //MyListView.ItemsSource = _post;
        //}

 
        private async void btnInsertar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InserPost());
        }

        private void btnGet_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {

        }
    }
}