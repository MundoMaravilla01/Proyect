using Proyect.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyect.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClienteVista : ContentPage
    {
        ClienteModel contexto = new ClienteModel();

        public ClienteVista()
        {
            InitializeComponent();
            BindingContext = contexto;
            LvUsuarios.ItemSelected += LvUsuarios_ItemSelected;

        }

        public string Nombre { get; private set; }
        public string Apellido { get; private set; }

        private void LvUsuarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                ClienteModel modelo = (ClienteModel)e.SelectedItem;
                contexto.Nombre = modelo.Nombre;
                contexto.Apellido = modelo.Apellido;

            }


        }
    }
}