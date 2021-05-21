using Proyect.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proyect.ViewModels
{
     public class MainPageViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainPageViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                Name = "pan",
                Price = 0.60m,
                Imagen = "pan.png",
                HasOffer = false
                },
                 new Product
                 {
                     Name = "cafe",
                     Price = 60.0m,
                     Imagen = "cafe.png",
                     HasOffer = false
                 },
                  new Product
                  {
                      Name = "chocolate",
                      Price = 60.0m,
                      Imagen = "chocolate.jpg",
                      HasOffer = false
                  },

             };

            
                
            
        }
    }
}
