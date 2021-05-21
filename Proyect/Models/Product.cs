using System;
using System.Collections.Generic;
using System.Text;

namespace Proyect.Models
{
      public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Imagen { get; set; }
        
        public bool HasOffer { get; set; }

        public decimal OfferPrice { get; set; }

    }
}
