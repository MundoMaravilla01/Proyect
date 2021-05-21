using Proyect.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proyect.ViewModels
{
    public class ClienteModel : Clientes

    {
        public ObservableCollection<Clientes> Usuarios { get; set; }
        ClienteServicio servicio = new ClienteServicio();
        Clientes modelo;

        public ClienteModel()
        {
           Usuarios = servicio.Consultar();
            GuardarCommand = new Command(async () => await Guardar(), () =>!Isbusy);
            ModificarCommand = new Command(async () =>await Modificar(), () =>!Isbusy);
            EliminarCommand = new Command(async () => await Eliminar(), () =>!Isbusy);
            LimpiarCommand = new Command(Limpiar, () => !Isbusy);
        }

        public Command GuardarCommand { get; set; }

        public Command ModificarCommand { get; set; }

        public Command EliminarCommand { get; set; }
        public Command LimpiarCommand { get; set; }

        private async Task Guardar() {
            Isbusy = true;
            Guid IdUsuario = Guid.NewGuid();
            modelo = new Clientes() {
                Nombre = Nombre,
                Apellido = Apellido,
                Edad = Edad,
                Id = IdUsuario.ToString()

            };
            servicio.Guardar(modelo);
            await Task.Delay(2000);

            Isbusy = false;

        }
        private async Task Modificar()
        {
            Isbusy = true;

            modelo = new Clientes()
            {
                Nombre = Nombre,
                Apellido = Apellido,
                Edad = Edad,
                Id = Id

            };
            servicio.Modificar(modelo);
            await Task.Delay(2000);
            Isbusy = false;

        }
        private async Task Eliminar()
        {
            Isbusy = true;
            Guid IdUsuario = Guid.NewGuid();
            modelo = new Clientes()
            {
                Nombre = Nombre,
                Apellido = Apellido,
                Edad = Edad,
                Id = IdUsuario.ToString()

            };
            servicio.Eliminar(Id);
            await Task.Delay(2000);
            Isbusy = false;

        }

        private void Limpiar(){
            Nombre = "";
            Apellido ="";
            Edad = 0;
            Id = "";
        }


    }
}
