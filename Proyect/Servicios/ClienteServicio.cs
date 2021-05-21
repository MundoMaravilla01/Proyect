using Proyect.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Proyect.ViewModels
{
    public class ClienteServicio
    {
        public ObservableCollection<Clientes> Usuario { get; set; }

        public ClienteServicio()
        {
            if (Usuario == null)
            {
                Usuario = new ObservableCollection<Clientes>();
            }
        }
        public ObservableCollection<Clientes> Consultar()
        {
            return Usuario;


        }
        public void Guardar(Clientes modelo)
        {
            Usuario.Add(modelo);
        }
        public void Modificar(Clientes modelo)
        {

            for (int i = 0; 1 < Usuario.Count; i++)

            {
                if (Usuario[i].Id == modelo.Id)
                {
                    Usuario[i] = modelo;
                }
            }
        }

        public void Eliminar(string idUsuario)
        {

            Clientes modelo = Usuario.FirstOrDefault(u => u.Id == idUsuario);
            Usuario.Remove(modelo);
        }
    }

}
